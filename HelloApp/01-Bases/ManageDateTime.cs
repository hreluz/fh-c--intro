partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 08, 15);

        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($"Date and current hour {now}");
        Console.WriteLine($"Current day {today}");
        Console.WriteLine($"One week ago was: {oneWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Custom date: {customDate}");
        Console.WriteLine($"Week day: {weekDay}");

    }
}