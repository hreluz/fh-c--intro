partial class Program
{
    static void ShowNumericTypes()
    {
        var integerNumber = int.MaxValue;
        double doubleNumber = 3.1416;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;

        WriteLine($"Integer: {integerNumber}");
        WriteLine($"Double: {doubleNumber}");
        WriteLine($"Float: {floatingNumber}");
        WriteLine($"Long: {longNumber}");
        WriteLine($"Monetary: {monetaryNumber}");
    }
}