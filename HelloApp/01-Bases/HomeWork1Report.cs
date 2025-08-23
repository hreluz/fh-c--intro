partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        WriteLine($"Product: {product}");
        WriteLine($"Quantity sold: {quantitySold * unitPrice}");
        WriteLine($"Total Amount: {totalAmount:C}");
    }

    static void SalaryCalculator()
    {
        WriteLine("Salary calculator");
        WriteLine();
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        WriteLine("Enter the number of hours: ");
        double hours = double.Parse(Console.ReadLine()!);
        WriteLine("Enter your salary hour rate: ");
        double rate = double.Parse(Console.ReadLine()!);
        double salary = hours * rate;
        WriteLine($"The salary for {name} is {salary}");
    }
}