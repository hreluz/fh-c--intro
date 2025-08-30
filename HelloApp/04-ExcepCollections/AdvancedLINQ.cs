namespace AdvancedLinq
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }

    class Ability
    {
        public int CharacterId { get; set; }
        public string? Description { get; set; }
    }
    class Statistic
    {
        public int CharacterId { get; set; }
        public int Power { get; set; }
    }
    class Program
    {
        public static void AdvancedLINQ()
        {
            List<Character> characters =
            [
                new Character { Id = 1, Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
                new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
                new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" },
                new Character { Id = 4, Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
                new Character { Id = 5, Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
          ];

            List<Ability> abilities =
            [
                new Ability { CharacterId = 1, Description = "Sentido arácnido" },
                new Ability { CharacterId = 1, Description = "Trepar paredes" },
                new Ability { CharacterId = 2, Description = "Inteligencia y armadura de alta tecnología" },
                new Ability { CharacterId = 3, Description = "Super fuerza" },
                new Ability { CharacterId = 4, Description = "Reflejos aumentados" },
                new Ability { CharacterId = 5, Description = "Magia y hechicería" }
            ];
            List<Statistic> statistics =
            [
                new Statistic { CharacterId = 1, Power = 85 },
                new Statistic { CharacterId = 2, Power = 90 },
                new Statistic { CharacterId = 3, Power = 88 },
                new Statistic { CharacterId = 4, Power = 80 },
                new Statistic { CharacterId = 5, Power = 95 }
            ];

            var teamQuery = from c in characters
                            group c by c.Team into team
                            select team;

            var teamsMethod = characters.GroupBy(c => c.Team);

            foreach (var team in teamQuery)
            {
                WriteLine($"Team: {team.Key}");

                foreach (var character in team)
                {
                    WriteLine($"-- {character.Name}");
                }

            }

            //Join collections
            var characterWithAbilities = from c in characters
                                         join a in abilities on c.Id equals a.CharacterId
                                         select new { c.Alias, c.Name, a.Description };

            WriteLine();
            WriteLine("Characters and skills");
            WriteLine("------------------------");

            foreach (var character in characterWithAbilities)
            {
                WriteLine($"{character.Alias} {character.Name} - Skill: {character.Description}");
            }

            WriteLine();
            WriteLine("Total character powers");
            WriteLine("------------------------");

            int totalPower = statistics.Sum(s => s.Power);
            WriteLine($"Total power of characters: {totalPower}");

            var avengersPower = (from c in characters
                                 join s in statistics on c.Id equals s.CharacterId
                                 where c.Team == "Avengers"
                                 select s.Power).Average();
            WriteLine($"Avengers power of characters: {avengersPower:F2}");

            var abilitiesByCharacter = from c in characters
                                       join a in abilities on c.Id equals a.CharacterId
                                       group a by c.Alias into groupAbilities
                                       select new { Character = groupAbilities.Key, Count = groupAbilities.Count() };

            WriteLine("Number of skills by character");
            WriteLine();

            foreach (var character in abilitiesByCharacter)
            {
                WriteLine($"{character.Character}: {character.Count} skill");
            }
        }
    }
}