using MyMonkeyApp.Models;

namespace MyMonkeyApp.Services
{
    public class MonkeyService
    {
        private readonly List<Monkey> _monkeys;

        public MonkeyService()
        {
            _monkeys = InitializeMonkeys();
        }

        private List<Monkey> InitializeMonkeys()
        {
            return new List<Monkey>
            {
                new Monkey("Chimpanzee", "Great Apes", "Tropical forests of Africa", "Central and West Africa", "Endangered", 45, "Omnivore"),
                new Monkey("Bonobo", "Great Apes", "Congo Basin forests", "Democratic Republic of Congo", "Endangered", 40, "Omnivore"),
                new Monkey("Orangutan", "Great Apes", "Rainforests of Borneo and Sumatra", "Southeast Asia", "Critically Endangered", 35, "Frugivore"),
                new Monkey("Gorilla", "Great Apes", "Mountains and forests of central Africa", "Central Africa", "Critically Endangered", 35, "Herbivore"),
                new Monkey("Gibbon", "Lesser Apes", "Tropical rainforests of Southeast Asia", "Southeast Asia", "Endangered", 25, "Frugivore"),
                new Monkey("Baboon", "Old World Monkeys", "Savannas and semi-arid regions of Africa", "Africa", "Stable", 20, "Omnivore"),
                new Monkey("Macaque", "Old World Monkeys", "Asia and North Africa", "Asia", "Stable", 25, "Omnivore"),
                new Monkey("Vervet Monkey", "Old World Monkeys", "Southern and East Africa", "Africa", "Stable", 15, "Omnivore"),
                new Monkey("Capuchin Monkey", "New World Monkeys", "Central and South America", "Americas", "Stable", 20, "Omnivore"),
                new Monkey("Spider Monkey", "New World Monkeys", "Tropical forests of Central and South America", "Americas", "Vulnerable", 22, "Frugivore"),
                new Monkey("Howler Monkey", "New World Monkeys", "Rainforests of Central and South America", "Americas", "Stable", 15, "Herbivore"),
                new Monkey("Squirrel Monkey", "New World Monkeys", "Amazon rainforest", "South America", "Stable", 15, "Omnivore"),
                new Monkey("Tamarin", "New World Monkeys", "Amazon rainforest", "South America", "Vulnerable", 12, "Omnivore"),
                new Monkey("Marmoset", "New World Monkeys", "South America", "South America", "Stable", 10, "Omnivore"),
                new Monkey("Proboscis Monkey", "Old World Monkeys", "Mangrove forests of Borneo", "Southeast Asia", "Endangered", 20, "Herbivore"),
                new Monkey("Golden Snub-nosed Monkey", "Old World Monkeys", "Temperate forests of China", "China", "Endangered", 20, "Herbivore"),
                new Monkey("Japanese Macaque", "Old World Monkeys", "Japan", "Japan", "Stable", 25, "Omnivore"),
                new Monkey("Mandrill", "Old World Monkeys", "Tropical rainforests of equatorial Africa", "Central Africa", "Vulnerable", 20, "Omnivore"),
                new Monkey("Langur", "Old World Monkeys", "South and Southeast Asia", "Asia", "Stable", 20, "Herbivore"),
                new Monkey("Colobus Monkey", "Old World Monkeys", "Forests of Africa", "Africa", "Vulnerable", 20, "Herbivore")
            };
        }

        public List<Monkey> GetAllMonkeys()
        {
            return _monkeys;
        }

        public List<Monkey> GetMonkeysByFamily(string family)
        {
            return _monkeys.Where(m => m.Family.Equals(family, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Monkey> GetEndangeredMonkeys()
        {
            return _monkeys.Where(m => m.Status.Contains("Endangered") || m.Status == "Critically Endangered").ToList();
        }

        public List<string> GetUniqueFamilies()
        {
            return _monkeys.Select(m => m.Family).Distinct().OrderBy(f => f).ToList();
        }

        public int GetTotalCount()
        {
            return _monkeys.Count;
        }

        public Monkey? GetMonkeyByName(string name)
        {
            return _monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Monkey GetRandomMonkey()
        {
            var random = new Random();
            int index = random.Next(_monkeys.Count);
            return _monkeys[index];
        }

        public Monkey? GetMonkeyByIndex(int index)
        {
            if (index >= 0 && index < _monkeys.Count)
                return _monkeys[index];
            return null;
        }

        public void DisplayMonkeys(List<Monkey> monkeys)
        {
            Console.WriteLine($"{"Name",-25} {"Family",-20} {"Status",-20} {"Lifespan",-10} {"Diet",-12}");
            Console.WriteLine(new string('-', 90));

            foreach (var monkey in monkeys)
            {
                Console.WriteLine($"{monkey.Name,-25} {monkey.Family,-20} {monkey.Status,-20} {monkey.AverageLifespan + " years",-10} {monkey.Diet,-12}");
            }
        }

        public void DisplayMonkeyDetails(Monkey monkey)
        {
            Console.WriteLine($"🐒 {monkey.Name}");
            Console.WriteLine($"   Family: {monkey.Family}");
            Console.WriteLine($"   Habitat: {monkey.Habitat}");
            Console.WriteLine($"   Region: {monkey.Region}");
            Console.WriteLine($"   Conservation Status: {monkey.Status}");
            Console.WriteLine($"   Average Lifespan: {monkey.AverageLifespan} years");
            Console.WriteLine($"   Diet: {monkey.Diet}");
            Console.WriteLine();
        }
    }
}
