using System.Runtime.CompilerServices;

partial class Program
{
    static void LoopControlExamples()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                continue;
            }

            if (i == 5)
            {
                break;
            }

            WriteLine(i);

        }

        while (true)
        {
            WriteLine("This will always execute");
        }

        for (; ; )
        {
            WriteLine("This too");
        }
    }
}