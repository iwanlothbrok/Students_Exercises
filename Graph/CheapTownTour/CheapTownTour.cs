using System.Collections.Generic;
using System;
using System.Linq;

namespace CheapTownTour
{
    public class CheapTownTour
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

            // Implement algorithm here

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
