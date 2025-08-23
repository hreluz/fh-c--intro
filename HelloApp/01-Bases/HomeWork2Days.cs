using System.Globalization;

partial class Program
{
    static void LivedDays()
    {
        DateTime birthDate = new DateTime(1963, 08, 10);
        TimeSpan difference = DateTime.Now - birthDate;

        WriteLine($"You have lived {difference.Days} days");
    }

    static void DaysUntilNextBirthday()
    {
        WriteLine("Enter your birthdate (dd/mm/aaaa): ");
        string? birthDateString = Console.ReadLine()!;
        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        int daysRemaining = (nextBirthday - currentDate).Days;
        WriteLine($"You will need to wait {daysRemaining} for your next birthdate");
    }
}