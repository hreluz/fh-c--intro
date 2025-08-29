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

            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"The amount you enter was: {amountValue:C}");
            }
            else
            {
                WriteLine("It cannot transform the number");
            }

            // double amountValue = double.Parse(amount);

            // WriteLine($"The amount you enter is :{amountValue:C}");
            ValidateAge(16);
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
        finally
        {
            Console.ResetColor();
            WriteLine("This will always be executed");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("Age should be older than 18");
        }
    }
}