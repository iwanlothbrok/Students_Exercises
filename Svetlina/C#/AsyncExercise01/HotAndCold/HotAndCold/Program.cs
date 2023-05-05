

public class Program
{
	public static void Main()
	{
		Thread t1 = new Thread(PrintCold);
		t1.Start();

		t1.Join();

		PrintHot();
	}
	public static void PrintCold()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(" Cold ");
			Thread.Sleep(200);
		}
	}
	public static void PrintHot()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Hot");
			Thread.Sleep(200);
		}
	}
}