partial class Program
{
    static void Conditionals()
    {
        int age = 19;

        if (age >= 18)
        {
            WriteLine("You are old enough");
        }
        else
        {
            WriteLine("You are underage");
        }

        string message = age >= 18 ? "You are old enough" : "You are underage";

        WriteLine(message);

        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("It is too hot");
        }
        else if (temperature > 20)
        {
            WriteLine("It's cool");
        }
        else
        {
            WriteLine("It's chilling");
        }

        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Monday");
                break;
            case 2:
                WriteLine("Tuesday");
                break;
            case 3:
                WriteLine("Wednesday");
                break;
            default:
                WriteLine("No day saved");
                break;
        }

        string dayMessage = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            _ => "Valid day"
        };

        WriteLine(dayMessage);
    }
}