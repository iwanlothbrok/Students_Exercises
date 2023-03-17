using System;
using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

namespace PathBetweenStores
{
    public class PathBetweenStores
    {
        private static Dictionary<int, List<Edge>> edgesByNode;

        public static void Main()
        {
            int streets = int.Parse(Console.ReadLine());

            edgesByNode = ReadEdges(streets);

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int[] distance = new int[edgesByNode.Keys.Max() + 1];

            Array.Fill(distance, int.MaxValue);
            distance[start] = 0;

            int[] previous = new int[edgesByNode.Keys.Max() + 1];
            previous[start] = -1;

            OrderedBag<int> queue = new OrderedBag<int>(
                Comparer<int>.Create((f, s) => distance[f] - distance[s]));

            queue.Add(start);

            // Implement algorithm here

            Console.WriteLine(distance[end]);
            Console.WriteLine(PrintPath(previous, end));
        }

        private static string PrintPath(int[] previous, int end)
        {
            Stack<int> path = new Stack<int>();
            int node = end;
            while (node != -1)
            {
                path.Push(node);
                node = previous[node];
            }

            return string.Join(" ", path);
        }

        private static Dictionary<int, List<Edge>> ReadEdges(int edgeQty)
        {
            Dictionary<int, List<Edge>> result = new Dictionary<int, List<Edge>>();
            for (int i = 0; i < edgeQty; i++)
            {
                int[] edgeData = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                int firstNode = edgeData[0];
                int secondNode = edgeData[1];
                int weight = edgeData[2];

                Edge edge = new Edge(firstNode, secondNode, weight);

                if (!result.ContainsKey(firstNode))
                {
                    result.Add(firstNode, new List<Edge>());
                }

                if (!result.ContainsKey(secondNode))
                {
                    result.Add(secondNode, new List<Edge>());
                }

                result[firstNode].Add(edge);
                result[secondNode].Add(edge);
            }

            return result;
        }
    }
}
