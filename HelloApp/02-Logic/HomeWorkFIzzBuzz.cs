partial class Program
{
    static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                WriteLine("Buzz");
            }
            else
            {
                WriteLine(i);
            }
            
        }
    }
}