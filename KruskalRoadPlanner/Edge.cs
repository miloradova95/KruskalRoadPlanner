namespace KruskalRoadPlanner
{
    public class Edge
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Weight { get; set; }

        public Edge(string from, string to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{From} - {To} (Weight: {Weight})";
        }
    }
}
