namespace ThomasLiebregts.Variance.App;

public abstract class Vehicle
{
	public Vehicle(int numberOfWheels)
	{
		NumberOfWheels = numberOfWheels;
	}

	public int NumberOfWheels { get; }
}