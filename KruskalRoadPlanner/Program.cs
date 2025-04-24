using System;
using System.Collections.Generic;

namespace KruskalRoadPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🚗 Road Network Planner using Kruskal's Algorithm\n");

            // Create and generate a random graph
            var graph = new Graph();
            graph.GenerateRandomGraph(nodeCount: 6, maxEdgesPerNode: 3, maxWeight: 15);

            // Show the full graph
            Console.WriteLine("📍 Full Road Network:");
            graph.PrintGraph();

            // Apply Kruskal's algorithm
            Console.WriteLine("\n🧭 Minimum Spanning Tree (Roads to Build):");
            var mst = Kruskal.FindMST(graph);

            foreach (var edge in mst)
            {
                Console.WriteLine(edge);
            }

            // Show total construction cost
            int totalCost = Kruskal.CalculateTotalWeight(mst);
            Console.WriteLine($"\n💰 Total Construction Cost: {totalCost}");
        }
    }
}