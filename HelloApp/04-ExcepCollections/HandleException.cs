partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {
            Write("Enter amount: ");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount)) return;

            double amountValue = double.Parse(amount);

            WriteLine($"The amount you enter is :{amountValue:C}");
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Divizion by zero");
        }
        catch (FormatException) when (amount?.Contains("$") == true)
        {
            WriteLine("It is not necessary to enter '$'");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ex.Message);
        }
    }
}