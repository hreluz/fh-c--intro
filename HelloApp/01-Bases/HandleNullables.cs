partial class Program
{
    static void HandleNullables()
    {
        string firstName = "Bruce";
        string? lastName = null;

        Console.WriteLine($"Name: {firstName}");

        if (lastName != null)
        {
            Console.WriteLine($"LastName: {lastName}");
        }
        else
        {
            Console.WriteLine($"LastName not specified");
        }

        Console.WriteLine($"LastName: {lastName ?? "LastName not specified!"}");

        string? text = null;
        Console.WriteLine(text?.Length);

    }
}