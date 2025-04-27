namespace KruskalLibrary
{
    public class Connection // base class for edge and vertex classes, holds the connection properties from and to
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