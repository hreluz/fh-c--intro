partial class Program
{
    static void Generics()
    {
        string[] names = { "Bruce", "Clark", "Diana" };
        int[] numbers = { 1, 2, 3, 4 };

        Console.WriteLine($"Size of numeric array: {GetIntArrayLength(numbers)}");
        Console.WriteLine($"Size of string array: {GetIStringArrayLength(names)}");

        Console.WriteLine($"Size of numeric array: {GetArrayLength(numbers)}");
        Console.WriteLine($"Size of string array: {GetArrayLength(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "I am text now" };

        numberBox.Show();
        stringBox.Show();
    }

    // No generic method
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetIStringArrayLength(string[] array)
    {
        return array.Length;
    }

    // Generic method
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Content: ${Content}");
    }
}