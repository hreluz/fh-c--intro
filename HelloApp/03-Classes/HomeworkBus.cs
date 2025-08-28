partial class Program
{
    static void BusFleet()
    {
        Bus bus1 = new Bus("Mercedes", "AC-1", 2024, 1000, 2344.2);
        Bus bus2 = new Bus("BMW", "AC-2", 2023, 4454, 5000);
        Bus bus3 = new Bus("Volksvagen", "AC-3", 2014, 10, 2888.2);

        bus1.ShowInfo();
        Fleet fleet = new Fleet();
        fleet.addBus(bus1);
        fleet.addBus(bus2);
        fleet.addBus(bus3);

        fleet.showBuses();
        bus3.Drive(30);
        bus3.ShowPrice();
        fleet.showBuses();

    }


    class Bus
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int TotalKms { get; set; }
        public double Price { get; set; }

        public Bus(string brand, string model, int year, int totalkms, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            TotalKms = totalkms;
            Price = price;
        }

        public void Drive(int kms)
        {
            TotalKms += kms;
        }

        public void ShowPrice()
        {
            WriteLine($"The price of the car {Brand} is {Price:C}");
        }

        public void ShowInfo()
        {
            WriteLine($"The bus brand is {Brand}, the model {Model} from {Year}. It costs {Price} and has {TotalKms} kms");
        }
    }

    class Fleet
    {
        private List<Bus> buses = new List<Bus>();

        public void addBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void showBuses()
        {
            WriteLine("--- Show buses ---");

            foreach (var bus in buses)
            {
                bus.ShowInfo();
            }
        }
    }
}