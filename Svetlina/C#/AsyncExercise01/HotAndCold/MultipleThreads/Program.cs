using Microsoft.VisualBasic;

public class Program
{
	public static void Main()
	{
		Thread threadF = new Thread(MakingRequests);
		Thread threadS = new Thread(AccessingDatabase);
		Thread threadT = new Thread(Operations);


		threadF.Start();
		threadS.Start();
		threadT.Start();
	}
	static void MakingRequests()
	{
		Console.WriteLine("Making requests started using Thread 1");
		for (int i = 1; i < 6; i++)
		{
			Console.WriteLine($"Making requests: {i}");
		}
		Console.WriteLine("Making requests ended using Thread 1");
	}

	static void AccessingDatabase()
	{
		Console.WriteLine("Access database started using Thread 2");

		for (int i = 1; i < 6; i++)
		{
			Console.WriteLine($"Access database: {i}");

			if (i == 3)
			{
				Console.WriteLine("Performing the database operation started");
				Thread.Sleep(1000);
				Console.WriteLine("Performing the database operation completed");
			}
		}

		Console.WriteLine("Access database ended using Thread 2");
	}

	static void Operations()
	{
		Console.WriteLine("Operations started using Thread 3");

		for (int i = 1; i < 6; i++)
		{
			Console.WriteLine($"Operations: {i}");
		}

		Console.WriteLine("Operations ended using Thread 3");
	}
}