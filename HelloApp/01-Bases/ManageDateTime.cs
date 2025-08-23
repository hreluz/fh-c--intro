partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 08, 15);

        DayOfWeek weekDay = now.DayOfWeek;

        WriteLine($"Date and current hour {now}");
        WriteLine($"Current day {today}");
        WriteLine($"One week ago was: {oneWeekAgo.ToString("dd/MM/yyyy")}");
        WriteLine($"Custom date: {customDate}");
        WriteLine($"Week day: {weekDay}");

    }
}