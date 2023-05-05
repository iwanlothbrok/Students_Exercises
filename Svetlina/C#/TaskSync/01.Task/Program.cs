using System;
using System.Threading;
internal class Program
{
	static bool reserve = false;
	static object locker = new object();
	static void Main(string[] args)
	{
		// with lock
		locker = new Thread(Reserve);
		Reserve();
		Reserve();
	}
	static void Reserve()
	{
		lock (locker)
		{
			if (!reserve)
			{
				reserve = true;
				Console.WriteLine("Reserved");
			}
		}
	}

}

