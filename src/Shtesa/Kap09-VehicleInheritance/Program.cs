List<Vehicle> vehicles = new()
{
    new Car("SK-001-AA", 2018),
    new Truck("SK-999-BB", 2020, 12)
};

foreach (var v in vehicles)
    Console.WriteLine($"{v.Plate}: {v.ServiceCost():F2} den");

abstract class Vehicle
{
    public string Plate { get; }
    public int Year { get; }
    protected Vehicle(string plate, int year) { Plate = plate; Year = year; }
    public abstract decimal ServiceCost();
}

class Car : Vehicle
{
    public Car(string plate, int year) : base(plate, year) { }
    public override decimal ServiceCost() => 3500m;
}

class Truck : Vehicle
{
    public int CapacityTons { get; }
    public Truck(string plate, int year, int capacityTons) : base(plate, year)
    {
        CapacityTons = capacityTons;
    }
    public override decimal ServiceCost() => 7000m + CapacityTons * 500m;
}
