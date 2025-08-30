partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/example.txt";
        var fileName = Path.GetFileName(filePath);
        var fileExtension = Path.GetExtension(filePath);
        var directoryName = Path.GetDirectoryName(filePath);
        var combinedPath = Path.Combine("C:", "User", "Documents", "example.txt");
        var fullFilePath = Path.GetFullPath(filePath);


        WriteLine($"filePath: {filePath}");
        WriteLine($"Filename: {fileName}");
        WriteLine($"fileExtension: {fileExtension}");
        WriteLine($"directoryName: {directoryName}");
        WriteLine($"combinedPath: {combinedPath}");
        WriteLine($"fullFilePath: {fullFilePath}");
    }
}