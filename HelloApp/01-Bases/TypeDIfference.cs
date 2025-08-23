partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;

        y = 15;
        WriteLine($"x:{x}, y:{y}");

        Person person1 = new Person { Name = "Bruce" };
        Person person2 = person1;

        person2.Name = "Tim";
        WriteLine($"person1.Name: {person1.Name}");
    }
}

class Person
{
    public string? Name { get; set; }
}