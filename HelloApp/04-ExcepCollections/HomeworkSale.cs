partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };


        try
        {
            foreach (var sale in sales)
            {
                sale.showInfo();
            }

            WriteLine();
            WriteLine("Showing sales with amounts higher than 1000: ");

            var filteredSales = from c in sales
                                where c.Amount > 1000
                                select c;

            foreach (var sale in filteredSales)
            {
                sale.showInfo();
            }


            WriteLine();
            WriteLine("Group sales by category and calculate total by each: ");

            var groupSalesByQuery = from c in sales
                                    group c by c.Category into groupedCat
                                    select groupedCat;

            foreach (var groupSale in groupSalesByQuery)
            {
                var total = 0.0;
                foreach (var sale in groupSale)
                {
                    total += sale.Amount;
                }

                WriteLine($"Category: {groupSale.Key}, Total: {total:C}");
            }


            var groupSalesByMethod = sales.GroupBy(s => s.Category).Select(g => new { Category = g.Key, TotalAmount = g.Sum(s => s.Amount) });

            foreach (var group in groupSalesByMethod)
            {
                
                WriteLine($"Category: {group.Category}, Total: {group.TotalAmount:C}");
            }
        }
        catch (Exception e)
        {
            WriteLine($"Error when processing sales {e.Message}");
        }

    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }

    public void showInfo()
    {
        WriteLine($"Product: {Product}, Price: {Amount}, Category: {Category}");
    }
}