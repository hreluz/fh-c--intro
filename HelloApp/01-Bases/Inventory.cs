partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Keyboard"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        WriteLine("1. Buy product");
        WriteLine("2. Exit");

        int option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {
            WriteLine("Products inventory");
            WriteLine("--------------------");

            for (int i = 0; i < products.Length; i++)
            {
                WriteLine($"Product:  {products[i]}, Stock: {stock[i]}, Price: {prices[i]:C}");
            }

            WriteLine("\nInsert the product to buy: ");
            string? searchedProduct = Console.ReadLine();

            WriteLine("Insert the quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double total = quantity * prices[i];
                        stock[i] -= quantity;
                        WriteLine($"Success purchase: {total:C}");
                        WriteLine($"The stock now for this product is ${stock[i]}");
                    }
                    else
                    {
                        WriteLine("There are not enough products");
                    }
                }

            }
        }
        else if (option == 2)
        {
            WriteLine("Thanks for your visit");
        }
        else
        {
            WriteLine("Invalid option");
        }

    }
}