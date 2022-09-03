using ThomasLiebregts.Variance.App;

void WriteNumberOfWheels(IEnumerable<Vehicle> vehicles)
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
    new Bicycle()
};

WriteNumberOfWheels(listOfCars);
WriteNumberOfWheels(listOfBikes);