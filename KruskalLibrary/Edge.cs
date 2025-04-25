namespace KruskalLibrary
{
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
