using System;
using System.Collections.Generic;
using System.Linq;

namespace KruskalRoadPlanner
{
    public class Kruskal
    {
        public static List<Edge> FindMST(Graph graph)
        {
            var mst = new List<Edge>();
            var edges = graph.Edges.OrderBy(e => e.Weight).ToList();
            var unionFind = new UnionFind(graph.Nodes);

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