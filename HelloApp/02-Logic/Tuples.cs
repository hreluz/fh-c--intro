partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "hello");
        (int, string) myOtherTuple = (33, "bye");

        WriteLine($"Number: {myTuple.Item1}, Text: {myTuple.Item2}");
        WriteLine($"Number: {myOtherTuple.Item1}, Text: {myOtherTuple.Item2}");

        var operations = Operations(20, 10);
        WriteLine($"Add operation: {operations.Sum}, Subtract: {operations.Subtraction}");

        (int sum, int subtraction) = Operations(25, 15);
        WriteLine($"Add operation: {operations.Sum}, Subtract: {operations.Subtraction}");
    }


    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}