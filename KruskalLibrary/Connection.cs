namespace KruskalLibrary
{
    public class Connection
    {
        public string From { get; set; }
        public string To { get; set; }

        public Connection(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
