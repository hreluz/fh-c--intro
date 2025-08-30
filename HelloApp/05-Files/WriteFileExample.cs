partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/write-example.txt";
        var content = "We can write on a file";
        var streamWriter = new StreamWriter(filePath);

        streamWriter.WriteLine(content);
        streamWriter.WriteLine("The current time is: " + DateTime.Now.ToString("HH:mm:ss"));

        streamWriter.Dispose();
    }
}