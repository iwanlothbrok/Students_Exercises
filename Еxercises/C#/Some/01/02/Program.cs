using System.Collections.Generic;

class Program
{
    const string password = "042";
    static void Main()
    {
        Product pr = new Product(1, "asd", 145);


        Category cat = new Category(1, "catdg");
        cat.AddProcuts(pr);

        Company company = new Company(2, "23");

        company.AddCategory(cat);

        company.GetTopCategoryNameByProductCount();
    }
}


public class Category : ICategory
{
    public Category(int id, string name)
    {
        Id = id;
        Name = name;
        Products = new List<IProduct>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<IProduct> Products { get; set; }

    public void AddProcuts(IProduct product)
    {
        this.Products.Add(product);
    }
}

public interface ICategory
{
    void AddProcuts(IProduct product);
}
/// <summary>
///  -------------------------------------------------------------
/// </summary>
public class Product : IProduct
{
    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}
public interface IProduct
{
}
/// <summary>
///  -------------------------------------------------------------
/// </summary>
public interface ICompany
{
    void AddCategory(ICategory category);
    KeyValuePair<string, decimal> GetTopCategoryBySumOfProductPrices();
    string GetTopCategoryNameByProductCount();
    List<(string, decimal)> GetCategoriesWithSumOfTheProductPrices();
    List<IProduct> GetProductsBelongsToMultipleCategory();
}
public class Company : ICompany
{
    public Company(int id, string name)
    {
        Id = id;
        Name = name;
        Categories = new List<ICategory>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<ICategory> Categories { get; set; }

    public void AddCategory(ICategory category)
    {
        this.Categories.Add(category);
    }

    public string GetTopCategoryNameByProductCount()
    {
        string topName = string.Empty;
        int topCount = 0;
        foreach (var item in this.Categories)
        {
            Category? cat = item as Category;


            if (topCount < cat.Products.Count)
            {
                topName = cat.Name;
            }
        }

        return topName;

    }

    public KeyValuePair<string, decimal> GetTopCategoryBySumOfProductPrices()
    {
        Dictionary<string, decimal> categoryWithTopPrice = new Dictionary<string, decimal>();

        string topName = string.Empty;
        decimal topPrice = 0;
        foreach (var item in this.Categories)
        {
            Category? cat = item as Category;
            decimal currPrice = 0;

            foreach (var pr in cat.Products)
            {
                Product curr = pr as Product;

                currPrice += curr.Price;
            }


            if (topPrice < currPrice)
            {
                topPrice = currPrice;
                topName = cat.Name;
            }

        }

        categoryWithTopPrice.Add(topName, topPrice);


        return categoryWithTopPrice.FirstOrDefault();
    }

    public List<(string, decimal)> GetCategoriesWithSumOfTheProductPrices()
    {
        List<(string, decimal)> categories = new List<(string, decimal)>();
        //dic.Add()

        foreach (var item in this.Categories)
        {
            Category? cat = item as Category;
            decimal currPrice = 0;

            foreach (var pr in cat.Products)
            {
                Product curr = pr as Product;

                currPrice += curr.Price;
            }

            categories.Add((cat.Name, currPrice));
        }


        return categories;
    }
}
