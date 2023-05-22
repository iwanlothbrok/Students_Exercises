public class Program
{
	public static void Main()
	{
		Thread main = new Thread(MainTh);
		Thread worker = new Thread(WorkerTh);
		main.Start();
		worker.Start();
	}
	public static void MainTh()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine($"Main thread: {i}");
			Thread.Sleep(200);
		}
	}
	public static void WorkerTh()
	{
		for (int i = 11; i < 20; i++)
		{
			Console.WriteLine($"Worker thread: {i}");
			Thread.Sleep(200);
		}
	}
}