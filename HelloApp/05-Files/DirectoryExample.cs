partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files";
        var newDirectory = $"{directoryPath}/DirExample";
        Directory.CreateDirectory(newDirectory);

        if (Directory.Exists(newDirectory))
        {
            WriteLine("Directory exists");
        }

        Directory.Delete(newDirectory, recursive: true);
    }
}