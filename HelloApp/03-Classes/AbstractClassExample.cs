partial class Program
{
    static void AbstractClassExamples()
    {
        HomeAppliance myWasher = new WashingMachine { Brand = "Samsung" };
        HomeAppliance myMicrowave = new Microwave { Brand = "LG" };
        myWasher.TurnOn();
        myWasher.ShowBrand();
        myMicrowave.TurnOn();
        myMicrowave.ShowBrand();
    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }
    public abstract void TurnOn();

    public void ShowBrand()
    {
        WriteLine($"The electromdomestic's brand is: {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The washing machine is starting the washing cycle");
    }
}
class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("The microwave is heating the food");
    }
}