partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Ferrari";
        car.Year = 2025;
        WriteLine(car.ShowInfo());
        car.ShowMessage("Changing model");
        car.ChangeModel("Porshe");
        WriteLine(car.ShowInfo());

        Car.GeneralInfo();
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Car: {Model}, Year: {Year}";
    }

    public void ShowMessage(string message) => WriteLine(message);

    public static void GeneralInfo()
    {
        WriteLine("The car is one of the most used transports");
    }
}