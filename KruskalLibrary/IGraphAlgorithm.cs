using System.Collections.Generic;

namespace KruskalLibrary
{
    public interface IGraphAlgorithm
    {
        List<Edge> FindMinimumSpanningTree(Graph graph);
    }
}
