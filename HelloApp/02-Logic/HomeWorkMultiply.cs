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
}