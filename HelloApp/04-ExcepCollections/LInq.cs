using System.Reflection.Emit;

partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // query syntax
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        // method syntax
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            WriteLine(number);
        }

        WriteLine();


        foreach (var number in evenNumbersQuery)
        {
            WriteLine(number);
        }

        WriteLine();

        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }


        //Simple Queries

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        WriteLine("Avengers characters");
        WriteLine("-------------------");
        var avengersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        var avengersMethod = characters.Where(c => c.Team == "Avengers");

        foreach (var c in avengersQuery)
        {
            WriteLine($"{c}");
        }

        WriteLine();

        foreach (var c in avengersMethod)
        {
            WriteLine($"{c.Alias} {c.Name}");
        }

        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();

        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        WriteLine("Names in uppercase");
        WriteLine("-------------------");

        foreach (var c in uppercaseNamesQuery)
        {
            WriteLine($"{c}");
        }

        WriteLine();

        foreach (var c in uppercaseNamesMethod)
        {
            WriteLine($"{c}");
        }

        WriteLine();

        var sortedQuery = from c in characters
                          orderby c.Name descending
                          select c.Name;

        var sortedMethod = characters.OrderByDescending(c => c.Name);

        WriteLine("Order names descending");
        WriteLine("-------------------");
        foreach (var name in sortedQuery)
        {
            WriteLine(name);
        }

        WriteLine();

        foreach (var c in sortedMethod)
        {
            WriteLine(c.Name);
        }

        var firstThreeQuery = (from c in characters select c).Take(3);

        var firstThreeMethod = characters.Take(3);

        WriteLine();
        WriteLine("First 3 characters");
        foreach (var c in firstThreeQuery)
        {
            WriteLine(c.Name);
        }

        WriteLine();

        foreach (var c in firstThreeMethod)
        {
            WriteLine(c.Name);
        }
    }
    class MarvelCharacter
    {
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
}