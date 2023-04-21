using System;
using System.Collections.Generic;
using System.Linq;

namespace CableNetwork
{
	public class CableNetwork
    {
        private static List<Edge>[] graph;
        private static HashSet<int> spanningTree;

        public static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            int nodeCount = int.Parse(Console.ReadLine());
            int edgeCount = int.Parse(Console.ReadLine());

            spanningTree = new HashSet<int>();
            graph = ReadEdges(nodeCount, edgeCount);

            Console.WriteLine($"Budget used: {Prim(budget)}");
        }

		private static int Prim(int budget)
		{
			int totalCost = 0;

			while (budget > 0)
			{
				Edge minEdge = null;
				int minWeight = int.MaxValue;

				foreach (int node in spanningTree)
				{
					foreach (Edge edge in graph[node])
					{
						if (spanningTree.Contains(edge.First) && !spanningTree.Contains(edge.Second))
						{
							if (edge.Weight < minWeight)
							{
								minEdge = edge;
								minWeight = edge.Weight;
							}
						}
						else if (spanningTree.Contains(edge.Second) && !spanningTree.Contains(edge.First))
						{
							if (edge.Weight < minWeight)
							{
								minEdge = edge;
								minWeight = edge.Weight;
							}
						}
					}
				}

				if (minEdge == null)
				{
					break;
				}

				if (budget < minEdge.Weight)
				{
					break;
				}

				totalCost += minEdge.Weight;
				budget -= minEdge.Weight;
				spanningTree.Add(minEdge.First);
				spanningTree.Add(minEdge.Second);
			}

			return totalCost;
		}

		private static List<Edge>[] ReadEdges(int nodeCount, int edgeCount)
        {
            List<Edge>[] result = new List<Edge>[nodeCount];

            for (int i = 0; i < nodeCount; i++)
            {
                result[i] = new List<Edge>();
            }

            for (int i = 0; i < edgeCount; i++)
            {
                string[] edgeData = Console.ReadLine()
                    .Split(new char[] { ',', ' ' })
                    .ToArray();

                int first = int.Parse(edgeData[0]);
                int second = int.Parse(edgeData[1]);
                int weight = int.Parse(edgeData[2]);

                if (edgeData.Length == 4)
                {
                    spanningTree.Add(first);
                    spanningTree.Add(second);
                }

                Edge edge = new Edge(first, second, weight);

                result[first].Add(edge);
                result[second].Add(edge);
            }

            return result;
        }
    }
}
