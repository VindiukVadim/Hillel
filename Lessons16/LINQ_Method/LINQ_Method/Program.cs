using LINQ_Method.Models;

namespace LINQ_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var kiev = new Town { Name = "Kiev", Population = 2884,  FoundingDate = DateOnly.Parse("06.01.1100") };
            var dnipro = new Town { Name = "Dnipro", Population = 2884, FoundingDate = DateOnly.Parse("06.01.1100") };
            var kharkiv = new Town { Name = "Kharkiv", Population = 2884,  FoundingDate = DateOnly.Parse("06.01.1100") };
            var warshawa = new Town { Name = "Warshawa", Population = 1765000, FoundingDate = DateOnly.Parse("06.01.1150") };
            var praha = new Town { Name = "Praha", Population = 1309000, FoundingDate = DateOnly.Parse("06.01.1700") };
            var pekin = new Town { Name = "Pekin", Population = 1500000, FoundingDate = DateOnly.Parse("06.01.1700") };
            var Town = new List<Town>
            {
                kiev, dnipro, kharkiv, warshawa, praha, pekin
            };


            var mainLand = new List<Mainland>
            {
                new Mainland {Name = "Europe"},
                new Mainland {Name = "Asia"}
            };

            var ua = new Country { Name = "Ukraine", Capital = kiev, Mainland = "Europe" };
            var pl = new Country { Name = "Poland", Capital = warshawa, Mainland = "Europe" };
            var cz = new Country { Name = "Czech Republic", Capital = praha, Mainland = "Europe" };
            var ch = new Country { Name = "China", Capital = pekin, Mainland = "Asia" };

            var Country = new List<Country>
            {
                ua, pl, cz, ch,
            };
            ua.Towns = new List<Town> { kiev, kharkiv, dnipro };
            pl.Towns = new List<Town> { warshawa };
            cz.Towns = new List<Town> { praha };
            ch.Towns = new List<Town>() { pekin };



            //кількість країн по континентах
            var countriesByContinent = Country.GroupBy(c => c.Mainland).Select(g => new { Continent = g.Key, Count = g.Count() });
            foreach (var item in countriesByContinent)
            {
                Console.WriteLine($"Continent: {item.Continent}, Count: {item.Count}");
            }

            //топ-3 міст за населенням без урахування тих, що були засновані після 1200 року
            var topCities = Town
            .Where(c => c.FoundingDate.Year <= 1200)
            .OrderByDescending(c => c.Population)
            .Take(3);

            foreach (var city in topCities)
            {
                Console.WriteLine($"City: {city.Name}, Population: {city.Population}");
            }

            //країна з найбільшим населенням і її столицю
            var countryWithLargestPopulation = Country
               .OrderByDescending(c => c.Towns.Sum(ci => ci.Population))
               .First();

            Console.WriteLine($"Country: {countryWithLargestPopulation.Name}, Population: {countryWithLargestPopulation.Towns.Sum(ci => ci.Population)}");
            Console.WriteLine($"Capital: {countryWithLargestPopulation.Capital.Name}");

            //континенти з найбильшою кількістю міст, в яких населення перевищує 1.000.000
            var continentsWithLargeCities = Town
            .Where(c => c.Population > 1000000)
            .GroupBy(c => c.Country.Mainland)
            .Select(g => new { Continent = g.Key, Count = g.Count() })
            .OrderByDescending(g => g.Count);

            foreach (var item in continentsWithLargeCities)
            {
                Console.WriteLine($"Continent: {item.Continent}, Count: {item.Count}");
            }


        }
    }
}