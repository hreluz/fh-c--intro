partial class Program
{
    static void ShowStringType()
    {
        string name = "Bruce";
        string message = "Hello " + name;
        string interpolatedMessage = $"Hello {name}";

        WriteLine(message);
        WriteLine(interpolatedMessage);
        WriteLine($"Your name has {name.Length} characters");
        WriteLine($"Your name on uppercase is {name.ToUpper()}");
        WriteLine($"Your name on lowercase is {name.ToLower()}");

        int number = 13;

        WriteLine(number.ToString());
        bool isString = true;
        WriteLine(isString.ToString());
    }
}