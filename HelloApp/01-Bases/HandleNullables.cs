partial class Program
{
    static void HandleNullables()
    {
        string firstName = "Bruce";
        string? lastName = null;

        WriteLine($"Name: {firstName}");

        if (lastName != null)
        {
            WriteLine($"LastName: {lastName}");
        }
        else
        {
            WriteLine($"LastName not specified");
        }

        WriteLine($"LastName: {lastName ?? "LastName not specified!"}");

        string? text = null;
        WriteLine(text?.Length);

    }
}