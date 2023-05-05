using System;
using System.Threading;
namespace _04.Task
{
	internal class Program
	{
		static object locker = new object();
		static int count;
		static void Main(string[] args)
		{
			Thread[] threads = new Thread[10];

			for (int i = 0; i < 10; i++)
			{

				Thread thread = new Thread(CoffeeCounter);
				thread.Name = "Customer: " + i;
				thread.Start();
			}
		}
		static void CoffeeCounter()
		{

			Console.WriteLine($"{Thread.CurrentThread.Name} client is in the shop.");

			lock (locker)
			{
				count++;

				if (count > 5)
				{
					Monitor.Wait(locker);
				}
			}
			Console.WriteLine($"{Thread.CurrentThread.Name} made an order.");
			Thread.Sleep(1000);
			Console.WriteLine($"{Thread.CurrentThread.Name} took his order and left the shop.");

			lock (locker)
			{
				count--;

				if (count <= 5)
				{
					Monitor.PulseAll(locker);
				}
			}
		}

	}
}