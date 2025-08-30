partial class Program
{
    static void FileExample()
    {
        var filePath = "./05-Files/example.txt";
        var content = File.ReadAllText(filePath);

        System.Console.WriteLine(content);

        WriteLine();

        var lines = File.ReadLines(filePath);

        foreach (var line in lines)
        {
            WriteLine(line);
        }

        WriteLine();


        File.Copy(filePath, "./05-Files/example-copy.txt");
        File.Delete("./05-Files/example-copy.txt");
    }
}