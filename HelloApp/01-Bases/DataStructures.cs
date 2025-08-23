partial class Program
{
    static void DataStructures()
    {
        User batman = new User { Name = "Bruce", Age = 30 };
        batman.Greet();

        Point point = new Point { X = 301, Y = 200 };
        WriteLine($"Point ({point.X}, {point.Y})");

        CellPhone cellPhone = new CellPhone("Sony Ericson x8", 2008);
        WriteLine(cellPhone);
    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        WriteLine($"Hello, I am the user {Name}, and I am {Age} years old");
    }    
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

record CellPhone(string Model, int Year);