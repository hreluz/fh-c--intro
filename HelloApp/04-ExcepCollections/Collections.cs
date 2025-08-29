partial class Program
{
    static void Collections()
    {
        List<string> names = ["Bruce", "Clark", "Diana"];
        names.Add("Lex");

        ShowNames(names);
        names.Remove("Bruce");
        ShowNames(names);
    }

    private static void ShowNames(List<string> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}