using System;

namespace CatalogueSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			Catalogue catalogue = new Catalogue();

			// Add some products
			catalogue.AddProduct("Book", 12.99, 20, 1);
			catalogue.AddProduct("Pen", 0.99, 100, 2);
			catalogue.AddProduct("Chair", 89.99, 5, 3);

			// Print full catalogue
			catalogue.PrintCatalogue();

			// Print products of type 1 sorted by total value
			catalogue.PrintProductsByTypeSorted(1);

			// Print average unit price and total value of products of type 4
			catalogue.PrintAverageAndTotalByType(4);

			Console.ReadLine();
		}
	}

	class Product
	{
		private static int nextId = 1;

		public int Id { get; }
		public string Name { get; }
		public double Price { get; }
		public int Quantity { get; set; }
		public int Type { get; }

		public Product(string name, double price, int quantity, int type)
		{
			if (string.IsNullOrEmpty(name) || name.Length < 2 || name.Length > 20)
				throw new ArgumentException("Invalid name");

			if (price < 0.1)
				throw new ArgumentException("Invalid price");

			if (quantity < 0)
				throw new ArgumentException("Invalid quantity");

			if (type < 1 || type > 5)
				throw new ArgumentException("Invalid type");

			Id = nextId++;
			Name = name;
			Price = price;
			Quantity = quantity;
			Type = type;
		}

		public double TotalValue => Price * Quantity;

		public string UniqueCode => $"{Id}{Name.Substring(0, 2)}{Type}";
	}

	class Catalogue
	{
		private const int MaxProducts = 2000;

		private Product[] products = new Product[MaxProducts];
		private int count = 0;

		public void AddProduct(string name, double price, int quantity, int type)
		{
			if (count >= MaxProducts)
				throw new InvalidOperationException("Catalogue full");

			Product product = new Product(name, price, quantity, type);
			products[count++] = product;
		}

		public void PrintCatalogue()
		{
			//Array.Sort(products, 0, count, new ProductNameComparer());

			foreach (Product product in products)
			{
				if (product == null)
					break;

				Console.WriteLine($"{product.Id}, {product.Name}, {product.Price:F2} лв., {product.Quantity} броя, {product.Type} тип, {product.UniqueCode}");
			}
		}

		public void PrintProductsByTypeSorted(int type)
		{
			Product[] productsOfType = new Product[MaxProducts];
			int countOfType = 0;

			foreach (Product product in products)
			{
				if (product == null)
					break;

				if (product.Type == type)
				{
					productsOfType[countOfType++] = product;
				}
			}

			//Array.Sort(productsOfType, 0, countOfType, new ProductTotalValueComparer());

			foreach (Product product in productsOfType)
			{
				if (product == null)
					break;

				Console.WriteLine($"{product.Name}, {product.Price:F2} лв., {product.Quantity} броя, обща стойност {product.TotalValue:F2} лв.");
			}
		}

		public void printAverageAndTotalByType(int type)
		{
			// Variables to store the total price and quantity of items for the given type
			double totalPrice = 0;
			int totalQuantity = 0;
			int itemCount = 0;

			// Loop through all the products in the catalog
			foreach (Product product in products)
			{
				// Check if the product matches the given type
				if (product.Type == type)
				{
					// Add the price and quantity to the total for this type
					totalPrice += product.Price * product.Quantity;
					totalQuantity += product.Quantity;

					// Increment the item count for this type
					itemCount++;
				}
			}

			// Calculate the average price for this type
			double averagePrice = (totalQuantity > 0) ? totalPrice / totalQuantity : 0;

			// Print the results
			if (itemCount > 0)
			{
				Console.WriteLine("Average price for type {0}: {1:F2} lv.", type, averagePrice);
				Console.WriteLine("Total value for type {0}: {1:F2} lv.", type, totalPrice);
			}
			else
			{
				Console.WriteLine("No items found for type {0}.", type);
			}
		}
	}
}