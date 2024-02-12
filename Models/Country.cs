namespace BlazorProject.Models
{
    public class Country
    {
        public Name Name { get; set; }
        public Dictionary<string,Currency> Currencies { get; set; }
        public string[] Capital { get; set; }
        public Maps Maps { get; set; }
        public int Population { get; set; }
        public Flag Flags { get; set; }

    }

    public class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }

    }
    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

    }
    public class Maps
    {
        public string GoogleMaps { get; set; }

    }
    public class Flag
    {
        public string Png { get; set; }
        public string Svg { get; set; }
        public string Alt { get; set; }

    }
}
