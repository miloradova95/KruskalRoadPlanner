using System.Collections.Generic;

namespace KruskalLibrary
{
    // Union-Find (Disjoint Set Union) data structure with Generics (T must not be null)
    public class UnionFind<T> where T : notnull
    {
        private readonly Dictionary<T, T> parent; // Tracks the parent of each element
        private readonly Dictionary<T, int> rank; // Tracks the "depth" (rank) of each tree

        // Constructor: initializes each element as its own parent (separate set) and rank 0
        public UnionFind(IEnumerable<T> elements)
        {
            parent = new Dictionary<T, T>();
            rank = new Dictionary<T, int>();

            foreach (var element in elements)
            {
                parent[element] = element; // Initially, each element is its own parent
                rank[element] = 0;          // All trees start with rank 0
            }
        }

        // Finds the root of the set an item belongs to (with path compression)
        public T Find(T item)
        {
            if (!parent.ContainsKey(item))
                throw new KeyNotFoundException("Element not found in UnionFind set.");

            // Path compression: make the found root the direct parent to flatten the tree
            if (!parent[item].Equals(item))
                parent[item] = Find(parent[item]);

            return parent[item];
        }

        // Unites two sets if they are not already connected (using union by rank)
        public bool Union(T item1, T item2)
        {
            T root1 = Find(item1);
            T root2 = Find(item2);

            // If both elements are already in the same set, don't unite (would cause cycle)
            if (root1.Equals(root2))
                return false;

            // Attach smaller ranked tree under the root of the higher ranked tree
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
                // If ranks are equal, choose one root arbitrarily and increase its rank
                parent[root2] = root1;
                rank[root1]++;
            }

            return true;
        }
    }
}
