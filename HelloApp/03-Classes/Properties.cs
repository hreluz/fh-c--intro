partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("FORREST");
        animal.Species = "Wolf";
        animal.Age = 5;

        WriteLine($"Where lives: {animal.Habitat}, the animal is {animal.Species}, that has the category {animal.Category}");

        animal.Age = -5;
    }
}

class Animal
{
    public string Species { get; set; } = "Unknown";
    public string Category { get; set; } = "Vertebrates";

    private int age;

    public int Age
    {
        get { return Age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
            age = value;
        }
    }

    public string Habitat { get; }

    public Animal(string habitat)
    {
        Habitat = habitat;
    }
}
