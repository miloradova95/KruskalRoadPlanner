using System.Collections.Generic;
using System.Linq;

namespace KruskalLibrary
{
    // Implements the Kruskal algorithm by following the IGraphAlgorithm interface
    public class Kruskal : IGraphAlgorithm
    {
        // Entry point to find the Minimum Spanning Tree (MST) for a graph
        public List<Edge> FindMinimumSpanningTree(Graph graph)
        {
            return FindMST(graph);
        }

        // Main method: builds the MST using Kruskal's algorithm
        public static List<Edge> FindMST(Graph graph)
        {
            var mst = new List<Edge>(); // Final list of edges forming the MST

            // Sort all edges by ascending weight
            var edges = graph.Edges.OrderBy(e => e.Weight).ToList();

            // Union-Find structure to keep track of connected components
            var unionFind = new UnionFind<string>(graph.Nodes);

            // Process edges in increasing order
            foreach (var edge in edges)
            {
                // If adding this edge does not form a cycle, add it to the MST
                if (unionFind.Union(edge.From, edge.To))
                {
                    mst.Add(edge);
                }
            }

            return mst;
        }

        // Utility method to calculate the total cost (sum of weights) of the MST
        public static int CalculateTotalWeight(List<Edge> edges)
        {
            return edges.Sum(e => e.Weight);
        }
    }
}
