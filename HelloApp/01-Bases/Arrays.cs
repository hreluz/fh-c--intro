partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        int[] numbersArray = [5, 10, 15, 20, 25, 30];
        WriteLine($"First element: {numbersArray[0]}");
        WriteLine($"Third element: {numbersArray[2]}");
        WriteLine($"The number of elements is: {numbersArray.Length}");


        WriteLine($"Last element: {numbersArray[^1]}");
        WriteLine($"Before Last element: {numbersArray[^2]}");

        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];

        WriteLine($"The first three: {firstThree}");
        foreach (var number in firstThree)
        {
            WriteLine(number);
        }
        WriteLine();
        foreach (var number in fromIndexTwo)
        {
            WriteLine(number);
        }
    }
}