partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Keyboard"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        Console.WriteLine("1. Buy product");
        Console.WriteLine("2. Exit");

        int option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {
            Console.WriteLine("Products inventory");
            Console.WriteLine("--------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product:  {products[i]}, Stock: {stock[i]}, Price: {prices[i]:C}");
            }

            Console.WriteLine("\nInsert the product to buy: ");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("Insert the quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double total = quantity * prices[i];
                        stock[i] -= quantity;
                        Console.WriteLine($"Success purchase: {total:C}");
                        Console.WriteLine($"The stock now for this product is ${stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine("There are not enough products");
                    }
                }

            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Thanks for your visit");
        }
        else
        {
            Console.WriteLine("Invalid option");
        }

    }
}