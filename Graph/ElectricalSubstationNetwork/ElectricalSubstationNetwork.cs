using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectricalSubstationNetwork
{
	public class ElectricalSubstationNetwork
	{
		private static List<Edge> edges;

		public static void Main()
		{
			int towns = int.Parse(Console.ReadLine());
			int streets = int.Parse(Console.ReadLine());

			edges = ReadEdges(streets);

			List<Edge> sortedEdges = edges
				.OrderBy(edge => edge.Weight)
				.ToList();

			int[] parents = new int[towns];
			for (int i = 0; i < towns; i++)
			{
				parents[i] = i;
			}

			int totalCost = 0;

			foreach (Edge edge in sortedEdges)
			{
				int root1 = GetRoot(parents, edge.First);
				int root2 = GetRoot(parents, edge.Second);

				if (root1 != root2)
				{
					parents[root2] = root1;
					totalCost += edge.Weight;
				}
			}

			// Check if all towns are connected
			int root = GetRoot(parents, 0);
			for (int i = 1; i < towns; i++)
			{
				if (GetRoot(parents, i) != root)
				{
					totalCost = int.MaxValue;
					break;
				}
			}
			Console.WriteLine($"Total cost: {totalCost}");
		}

		private static int GetRoot(int[] parents, int node)
		{
			while (node != parents[node])
			{
				node = parents[node];
			}

			return node;
		}

		private static List<Edge> ReadEdges(int edges)
		{
			List<Edge> result = new List<Edge>();
			for (int i = 0; i < edges; i++)
			{
				int[] edgeData = Console.ReadLine()
					.Split(" - ")
					.Select(int.Parse)
					.ToArray();

				int first = edgeData[0];
				int second = edgeData[1];
				int weight = edgeData[2];

				result.Add(new Edge
				{
					First = first,
					Second = second,
					Weight = weight
				});
			}

			return result;
		}
	}
}
