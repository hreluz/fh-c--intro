partial class Program
{
    static void ShowNumericTypes()
    {
        var integerNumber = int.MaxValue;
        double doubleNumber = 3.1416;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;

        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Float: {floatingNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Monetary: {monetaryNumber}");
    }
}