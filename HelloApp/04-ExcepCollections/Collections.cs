partial class Program
{
    static void Collections()
    {
        List<string> names = ["Bruce", "Clark", "Diana"];
        names.Add("Lex");

        ShowNames(names);
        names.Remove("Bruce");
        ShowNames(names);

        Dictionary<int, string> students = new()
        {
            {1, "Bruce"},
            {2, "Clark"},
            {3, "Lex"},
        };

        students.Add(4, "Scarecrow");

        ShowStudents(students);

        students.Remove(1);

        ShowStudents(students);

        HashSet<string> users = ["Bruce", "Clark", "Diana"];
        users.Add("Lex");
        users.Add("Bruce");

        foreach (var user in users)
        {
            WriteLine(user);
        }
    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine($"Key: {student.Key}, Value: {student.Value}");
        }
    }

    private static void ShowNames(List<string> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}