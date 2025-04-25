using System.Collections.Generic;
using System.Linq;

namespace KruskalLibrary
{
    public class Kruskal : IGraphAlgorithm
    {
        public List<Edge> FindMinimumSpanningTree(Graph graph)
        {
            return FindMST(graph);
        }

        public static List<Edge> FindMST(Graph graph)
        {
            var mst = new List<Edge>();
            var edges = graph.Edges.OrderBy(e => e.Weight).ToList();
            var unionFind = new UnionFind<string>(graph.Nodes);

            foreach (var edge in edges)
            {
                if (unionFind.Union(edge.From, edge.To))
                {
                    mst.Add(edge);
                }
            }

            return mst;
        }

        public static int CalculateTotalWeight(List<Edge> edges)
        {
            return edges.Sum(e => e.Weight);
        }
    }
}