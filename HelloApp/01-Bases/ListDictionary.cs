partial class Program
{
    static void ListDictionary()
    {
        //Lists
        List<string> names = new List<string> { "Ed", "Edd", "Eddy" };

        names.Add("Bruce");

        WriteLine($"Total of names: {names.Count}");

        foreach (var name in names)
        {
            WriteLine(name);
        }

        names.Remove("Bruce");
        bool isPresent = names.Contains("Bruce");
        WriteLine($"Is Bruce in the list? {isPresent}");

        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ed"},
            {2, "Edd"},
            {3, "Eddy"},
        };


        foreach (var student in students)
        {
            WriteLine($"ID: {student.Key}, Name:{student.Value}");
        }
    }
}