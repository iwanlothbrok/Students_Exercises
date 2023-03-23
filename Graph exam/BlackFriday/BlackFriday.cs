using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackFriday
{
    public class Edge
    {
        public int First { get; set; }

        public int Second { get; set; }

        public int Weight { get; set; }
    }

    public class StartUp
    {
        private static List<Edge> edges;

        public static void Main()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());
            edges = ReadEdges(edgesCount);

            List<Edge> sortedEdges = edges.OrderBy(e => e.Weight).ToList();
            HashSet<int> nodes = edges.Select(e => e.First)
                .Union(edges.Select(e => e.Second))
                .ToHashSet();

            int[] parents = Enumerable.Repeat(-1, nodeCount)
                .ToArray();

            foreach (int node in nodes)
            {
                parents[node] = node;
            }

            int result = 0;
            // Implement algorithm here

            Console.WriteLine(result);
        }

        private static int GetRoot(int[] parents, int node)
        {
            while (node != parents[node])
            {
                node = parents[node];
            }

            return node;
        }

        private static List<Edge> ReadEdges(int num)
        {
            List<Edge> result = new List<Edge>();
            for (int i = 0; i < num; i++)
            {
                int[] edgeData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                result.Add(new Edge
                {
                    First = edgeData[0],
                    Second = edgeData[1],
                    Weight = edgeData[2]
                });
            }

            return result;
        }
    }
}
