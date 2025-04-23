using System;
using System.Collections.Generic;

namespace KruskalRoadPlanner
{
    public class Graph
    {
        public List<string> Nodes { get; private set; }
        public List<Edge> Edges { get; private set; }

        private Random random = new Random();

        public Graph()
        {
            Nodes = new List<string>();
            Edges = new List<Edge>();
        }

        public void AddNode(string name)
        {
            if (!Nodes.Contains(name))
            {
                Nodes.Add(name);
            }
        }

        public void AddEdge(string from, string to, int weight)
        {
            if (from != to && !EdgeExists(from, to))
            {
                Edges.Add(new Edge(from, to, weight));
                AddNode(from);
                AddNode(to);
            }
        }

        private bool EdgeExists(string from, string to)
        {
            return Edges.Exists(e =>
                (e.From == from && e.To == to) ||
                (e.From == to && e.To == from)); // undirected graph
        }

        public void GenerateRandomGraph(int nodeCount, int maxEdgesPerNode, int maxWeight)
        {
            Nodes.Clear();
            Edges.Clear();

            // Create nodes A, B, C, ...
            for (int i = 0; i < nodeCount; i++)
            {
                Nodes.Add(((char)('A' + i)).ToString());
            }

            // Try to connect each node with a few random others
            foreach (var from in Nodes)
            {
                int connections = random.Next(1, maxEdgesPerNode + 1);
                for (int i = 0; i < connections; i++)
                {
                    var to = Nodes[random.Next(Nodes.Count)];
                    if (from != to)
                    {
                        int weight = random.Next(1, maxWeight + 1);
                        AddEdge(from, to, weight);
                    }
                }
            }
        }

        public void PrintGraph()
        {
            Console.WriteLine("Towns (Nodes): " + string.Join(", ", Nodes));
            Console.WriteLine("Roads (Edges):");
            foreach (var edge in Edges)
            {
                Console.WriteLine(edge);
            }
        }
    }
}
