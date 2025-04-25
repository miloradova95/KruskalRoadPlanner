using System.Collections.Generic;

namespace KruskalLibrary
{
    public class UnionFind<T> where T : notnull
    {
        private readonly Dictionary<T, T> parent;
        private readonly Dictionary<T, int> rank;

        public UnionFind(IEnumerable<T> elements)
        {
            parent = new Dictionary<T, T>();
            rank = new Dictionary<T, int>();

            foreach (var element in elements)
            {
                parent[element] = element;
                rank[element] = 0;
            }
        }

        // Find with path compression
        public T Find(T item)
        {
            if (!parent.ContainsKey(item))
                throw new KeyNotFoundException("Element not found in UnionFind set.");

            if (!parent[item].Equals(item))
                parent[item] = Find(parent[item]);

            return parent[item];
        }

        // Union by rank
        public bool Union(T item1, T item2)
        {
            T root1 = Find(item1);
            T root2 = Find(item2);

            if (root1.Equals(root2))
                return false;

            if (rank[root1] < rank[root2])
            {
                parent[root1] = root2;
            }
            else if (rank[root1] > rank[root2])
            {
                parent[root2] = root1;
            }
            else
            {
                parent[root2] = root1;
                rank[root1]++;
            }

            return true;
        }
    }
}
