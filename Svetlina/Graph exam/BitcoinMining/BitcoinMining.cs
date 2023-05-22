using System;
using System.Collections.Generic;

namespace BitcoinMining
{
    public class Transaction
    {
		public string Hash { get; set; }

		public int Size { get; set; }

		public int Fees { get; set; }

		public string From { get; set; }

		public string To { get; set; }
	}

    public class StartUp
    {
        public static void Main()
        {

			int transactionCount = int.Parse(Console.ReadLine());

			List<Transaction> transactions = ReadItems(transactionCount);

			int maxCapacity = 1000000;
			int[,] table = new int[transactions.Count + 1, maxCapacity + 1];
			bool[,] included = new bool[transactions.Count + 1, maxCapacity + 1];

			// Knapsack algorithm
			for (int i = 1; i <= transactions.Count; i++)
			{
				Transaction currentTransaction = transactions[i - 1];

				for (int j = 1; j <= maxCapacity; j++)
				{
					int excludeTransaction = table[i - 1, j];
					int includeTransaction = 0;

					if (currentTransaction.Size <= j)
					{
						includeTransaction = currentTransaction.Fees + table[i - 1, j - currentTransaction.Size];
					}

					if (includeTransaction > excludeTransaction)
					{
						table[i, j] = includeTransaction;
						included[i, j] = true;
					}
					else
					{
						table[i, j] = excludeTransaction;
					}
				}
			}

			// Retrieve included transactions
			SortedSet<string> includedTransactions = new SortedSet<string>();
			int totalFees = table[transactions.Count, maxCapacity];
			int totalSize = 0;

			for (int row = included.GetLength(0) - 1; row >= 0; row--)
			{
				if (included[row, maxCapacity])
				{
					Transaction includedTransaction = transactions[row - 1];

					maxCapacity -= includedTransaction.Size;
					totalSize += includedTransaction.Size;
					includedTransactions.Add(includedTransaction.Hash);
				}
			}

			Console.WriteLine($"Total Size: {totalSize}");
			Console.WriteLine($"Total Fees: {totalFees}");
			foreach (string transaction in includedTransactions)
			{
				Console.WriteLine(transaction);
			}
		}

		private static List<Transaction> ReadItems(int transactionCount)
		{
			List<Transaction> transactions = new List<Transaction>();

			for (int i = 0; i < transactionCount; i++)
			{
				string[] transactionData = Console.ReadLine().Split();
				string hash = transactionData[0];
				int size = int.Parse(transactionData[1]);
				int fees = int.Parse(transactionData[2]);
				string from = transactionData[3];
				string to = transactionData[4];

				Transaction transaction = new Transaction
				{
					Hash = hash,
					Size = size,
					Fees = fees,
					From = from,
					To = to
				};

				transactions.Add(transaction);
			}

			return transactions;
		}
	}
}
