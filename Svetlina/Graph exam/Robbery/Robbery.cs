using System;
using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

namespace Robbery
{
    public class Edge
    {
        public int First { get; set; }

        public int Second { get; set; }

        public int Distance { get; set; }
    }

    public class StartUp
    {
        private static List<Edge>[] graph;

        public static void Main()
		{
			int nodesCount = int.Parse(Console.ReadLine());
			int edgesCount = int.Parse(Console.ReadLine());

			graph = ReadGraph(nodesCount, edgesCount);
			bool[] cameras = ReadCameras(nodesCount);

			string[] pointsData = Console.ReadLine().Split();

			int start = int.Parse(Console.ReadLine());
			int destination = int.Parse(Console.ReadLine());

			double[] distance = new double[cameras.Length];
			Array.Fill(distance, double.PositiveInfinity);

			distance[start] = 0;

			Comparer<int> comparer = Comparer<int>.Create((f, s) => distance[f].CompareTo(distance[s]));
			OrderedBag<int> queue = new OrderedBag<int>(comparer);

			queue.Add(start);

			while (queue.Count > 0)
			{
				int node = queue.RemoveFirst();
				if (node == destination)
				{
					break;
				}

				if (cameras[node])
				{
					continue;
				}

				foreach (Edge edge in graph[node])
				{
					int child = edge.First == node ? edge.Second : edge.First;

					if (cameras[child])
					{
						continue;
					}

					double newDistance = distance[node] + edge.Distance;
					if (newDistance < distance[child])
					{
						distance[child] = newDistance;
						queue.Add(child);
					}
				}
			}

			Console.WriteLine(distance[destination]);
		}

        private static bool[] ReadCameras(int nodes)
        {
            bool[] result = new bool[nodes];

            string[] line = Console.ReadLine()
                .Split();

            for (int i = 0; i < line.Length; i++)
            {
                char blackOrWhite = line[i][1];
                result[i] = blackOrWhite == 'w';
            }

            return result;
        }

        private static List<Edge>[] ReadGraph(int nodes, int edges)
        {
            var result = new List<Edge>[nodes];

            for (int node = 0; node < nodes; node++)
            {
                result[node] = new List<Edge>();
            }

            for (int i = 0; i < edges; i++)
            {
                int[] edgeData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int first = edgeData[0];
                int second = edgeData[1];
                int distance = edgeData[2];

                Edge edge = new Edge
                {
                    First = first,
                    Second = second,
                    Distance = distance,
                };

                result[first].Add(edge);
                result[second].Add(edge);
            }

            return result;
        }
    }
}
