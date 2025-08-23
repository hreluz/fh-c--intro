partial class Program
{
    static void Loops()
    {
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteration {counter}");
            counter++;
        }

        int number = 0;

        do
        {
            WriteLine($"Number: {number}");
            number++;
        } while (number < 3);

        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteration: {i}");
        }

        string[] fruits = ["Banana", "Apple", "Pear"];

        foreach (var fruit in fruits)
        {
            WriteLine(fruit);
        }

        List<string> names = ["Peter", "Lous", "Nancy"];
        foreach (var name in names)
        {
            WriteLine(name);
        }
    } 
}