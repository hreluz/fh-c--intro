partial class Program
{
    static void printMultiplicationTable(int number, int tableLimit)
    {
        WriteLine($"Multiplication table of the number {number} from 1 to {tableLimit}");
        WriteLine();

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }

        WriteLine();
    }

    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial number {number} from 1 to {number}");
        WriteLine();
        for (int i = 0; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
        WriteLine();
    }


    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}