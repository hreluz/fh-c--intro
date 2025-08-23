partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine(" Press a button to add: ");
        WriteLine("Press ESC to exist.\n");

        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine("You have pressed the ESC key");
                WriteLine($"You pressed {counter} time before exit");
                WriteLine($"Program finishes");
                break;
            }
            counter++;
        }
    }
}