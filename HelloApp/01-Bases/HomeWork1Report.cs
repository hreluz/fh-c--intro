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
}