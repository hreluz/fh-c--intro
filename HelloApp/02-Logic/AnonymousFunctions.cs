partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine(square(5));
        WriteLine(lambdaSquare(5));

        List<int> numbers = [1, 2, 3, 4, 5];
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var even in evenNumbers)
        {
            WriteLine(even);
        }
    }

    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    static Func<int, int> lambdaSquare = x => x * x;
}