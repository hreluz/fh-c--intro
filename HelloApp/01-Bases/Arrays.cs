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
    }
}