partial class Program
{
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;


        if (isEven && isGreaterThanTen)
        {
            WriteLine($"The number {number} is even and greater than 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            WriteLine($"The number {number} is odd and greater than 10");

        }
        else
        {
            WriteLine($"The number does not meet the conditions");
        }

        int age = 21;
        string category = age > 18 ? "Adult" : "Young";
        WriteLine(category);
    }
}