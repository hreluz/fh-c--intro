partial class Program
{
    static void ShowStringType()
    {
        string name = "Bruce";
        string message = "Hello " + name;
        string interpolatedMessage = $"Hello {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"Your name has {name.Length} characters");
        Console.WriteLine($"Your name on uppercase is {name.ToUpper()}");
        Console.WriteLine($"Your name on lowercase is {name.ToLower()}");

        int number = 13;

        Console.WriteLine(number.ToString());
        bool isString = true;
        Console.WriteLine(isString.ToString());
    }
}