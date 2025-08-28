partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new Product("Laptop", 2133.4, 5);
        Product mouse = new Product("Mouse", 22.4, 5);

        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInventory();

        laptop.Sell(1);
        inventory.ShowInventory();
    }


    class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ShowInfo()
        {
            WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                WriteLine($"Purchase done: {quantity} sold of {Name}");
                Stock--;
                return true;
            }

            WriteLine($"Stock not enough for {Name}");

            return false;
        }

    }

    class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowInventory()
        {
            WriteLine("Inventary products ...");
            foreach (var product in products)
            {
                product.ShowInfo();
            }
        }
    }
}

