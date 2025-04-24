using System.Collections.Generic;

namespace KruskalRoadPlanner
{
    public class UnionFind
    {
        private Dictionary<string, string> parent;

        public UnionFind(List<string> nodes)
        {
            parent = new Dictionary<string, string>();
            foreach (var node in nodes)
            {
                parent[node] = node;
            }
        }

        public string Find(string node)
        {
            if (parent[node] != node)
            {
                parent[node] = Find(parent[node]); // Path compression
            }
            return parent[node];
        }

        public bool Union(string node1, string node2)
        {
            string root1 = Find(node1);
            string root2 = Find(node2);

            if (root1 == root2)
                return false;

            parent[root2] = root1;
            return true;
        }
    }
}