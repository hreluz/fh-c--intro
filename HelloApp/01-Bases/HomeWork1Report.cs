partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quantity sold: {quantitySold * unitPrice}");
        Console.WriteLine($"Total Amount: {totalAmount:C}");
    }

    static void SalaryCalculator()
    {
        Console.WriteLine("Salary calculator");
        Console.WriteLine();
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter the number of hours: ");
        double hours = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter your salary hour rate: ");
        double rate = double.Parse(Console.ReadLine()!);
        double salary = hours * rate;
        Console.WriteLine($"The salary for {name} is {salary}");
    }
}