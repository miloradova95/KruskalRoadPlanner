namespace KruskalLibrary
{
// class representing an edge in a graph, inherits from Connection 
//and adds a weight property to represent the cost of the edge
    public class Edge : Connection  
    {
        public int Weight { get; set; }

        public Edge(string from, string to, int weight) : base(from, to)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{From} -- {To} [Weight: {Weight}]";
        }
    }
}