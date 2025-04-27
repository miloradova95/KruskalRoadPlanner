using System;
using System.Collections.Generic;

namespace KruskalLibrary
{
    public class Graph
    {
        // List of all town names (nodes)
        public List<string> Nodes { get; private set; }

        // List of all roads (edges) between towns
        public List<Edge> Edges { get; private set; }

        // Random generator for creating random graphs
        private Random random = new Random();

        public Graph()
        {
            Nodes = new List<string>();
            Edges = new List<Edge>();
        }

        // Adds a town (node) to the graph if it doesn't already exist
        public void AddNode(string name)
        {
            if (!Nodes.Contains(name))
            {
                Nodes.Add(name);
            }
        }

        // Adds a road (edge) between two towns with a certain cost (weight)
        public void AddEdge(string from, string to, int weight)
        {
            if (from != to && !EdgeExists(from, to)) // No self-loops and no duplicate edges
            {
                Edges.Add(new Edge(from, to, weight));
                AddNode(from); // Ensure both nodes exist
                AddNode(to);
            }
        }

        // Checks if a road already exists between two towns
        private bool EdgeExists(string from, string to)
        {
            return Edges.Exists(e =>
                (e.From == from && e.To == to) ||
                (e.From == to && e.To == from)); // Since it's an undirected graph
        }

        // Creates a random graph based on the given settings
        public void GenerateRandomGraph(int nodeCount, int maxEdgesPerNode, int maxWeight)
        {
            Nodes.Clear();
            Edges.Clear();

            // Create town names A, B, C, etc.
            for (int i = 0; i < nodeCount; i++)
            {
                Nodes.Add(((char)('A' + i)).ToString());
            }

            // For each town, create some random connections
            foreach (var from in Nodes)
            {
                int connections = random.Next(1, maxEdgesPerNode + 1); // Random number of connections
                for (int i = 0; i < connections; i++)
                {
                    var to = Nodes[random.Next(Nodes.Count)]; // Pick a random town
                    if (from != to)
                    {
                        int weight = random.Next(1, maxWeight + 1); // Random cost (weight)
                        AddEdge(from, to, weight);
                    }
                }
            }
        }

        // Prints all towns and roads to the console
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
