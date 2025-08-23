using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        DateTime birthday = DateTime.Parse("2 Marzo 2025");
        double cost = 25.50;

        WriteLine($"I have {friends} friends to invite to my party");
        WriteLine($"Celebration of my birthday will be {birthday}");
        WriteLine($"Format lardo {birthday:D}");
        WriteLine($"Entrance's cost will be: {cost:C}");
    }
}