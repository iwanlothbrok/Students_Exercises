public class Program
{
	public static void Main()
	{
		Task task = new Task(Run);
		task.Start();

		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("----------------");
		}

		

	}
	static void Run()
	{
		while(true)
		{
			Console.WriteLine("Endless Loop...");
		}
	}
}