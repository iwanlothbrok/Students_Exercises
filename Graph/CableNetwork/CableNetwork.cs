using System;
using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

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
            throw new NotImplementedException();
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
