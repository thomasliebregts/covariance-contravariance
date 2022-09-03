public abstract record Vehicle(int NumberOfWheels);
public record Car : Vehicle(4);
public record Bicycle : Vehicle(2);

public void WriteNumberOfWheels(IEnumerable<Vehicle> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        Console.WriteLine(vehicle.NumberOfWheels);
    }
}

var listOfCars = new List<Car>
{
    new Car(),
    new Car()
};

var listOfBikes = new List<Bicycle>
{
    new Bicycle();
};

WriteNumberOfWheels(listOfCars);
// Outputs:
// 4
// 4

WriteNumberOfWheels(listOfBikes);
// Outputs:
// 2