using System;
using System.Security.Cryptography;
using System.Threading;

namespace _02.Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Thread[] threads = new Thread[10];
			Account acc = new Account(500);

			for (int i = 0; i < 10; i++)
			{
				Thread t = new Thread(() =>
				{
					double withdrawn = acc.Withdrow(100);
				});
				threads[i] = t;
			}

			for (int i = 0;i<10; i++) 
			{
				threads[i].Start();
			}
		}
	}
	public class Account
	{
		private object balanceLock = new object();
		public Account(double balance)
		{
			this.Balance = balance;
		}
		public double Balance { get; set; }

		public double Withdrow(double amount)
		{
			lock (balanceLock)
			{
				double applyAmount = 0;
				if (this.Balance < 0)
				{
					throw new Exception("Negative Balance");
				}
				if (this.Balance >= amount)
				{
					Console.WriteLine($"Balance before Withdrawal: {this.Balance}");
					Console.WriteLine($"Amount to Withdraw: -{amount}");

					this.Balance -= amount;
					applyAmount = amount;
					Console.WriteLine($"Balance after Withdrawal: {this.Balance}");

					return applyAmount;
				}

			}

			return 0;
		}
	}
}