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

        Car sportsCar = new Car("BMW", 2020);
        WriteLine(sportsCar.ShowInfo());

        Car collectionCar = new Car { Model = "Cadillac", Year = 1980 };
        WriteLine(collectionCar.ShowInfo());

        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="Stepway", Year=2022},
            new Car(){Model="Captur", Year=2024}
        };

        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }
    }
}

class Car
{
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public Car()
    {

    }

    ~Car()
    {
        WriteLine("Destructor called, free");
    }

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