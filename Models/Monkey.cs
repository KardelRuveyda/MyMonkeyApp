namespace MyMonkeyApp.Models
{
    public class Monkey
    {
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Habitat { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int AverageLifespan { get; set; }
        public string Diet { get; set; } = string.Empty;

        public Monkey(string name, string family, string habitat, string region = "", string status = "Stable", int averageLifespan = 0, string diet = "Omnivore")
        {
            Name = name;
            Family = family;
            Habitat = habitat;
            Region = region;
            Status = status;
            AverageLifespan = averageLifespan;
            Diet = diet;
        }

        public override string ToString()
        {
            return $"{Name} ({Family}) - {Habitat}";
        }
    }
}
