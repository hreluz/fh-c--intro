partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        int[] numbersArray = [5, 10, 15, 20, 25, 30];
        Console.WriteLine($"First element: {numbersArray[0]}");
        Console.WriteLine($"Third element: {numbersArray[2]}");
        Console.WriteLine($"The number of elements is: {numbersArray.Length}");


        Console.WriteLine($"Last element: {numbersArray[^1]}");
        Console.WriteLine($"Before Last element: {numbersArray[^2]}");

        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];

        Console.WriteLine($"The first three: {firstThree}");
        foreach (var number in firstThree)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        foreach (var number in fromIndexTwo)
        {
            Console.WriteLine(number);
        }
    }
}