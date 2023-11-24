using Generator.cars;

namespace Generator.components;

internal class TripComputer
{
    public Car Car { get; set; } = null!;

    public void ShowFuelLevel()
    {
        Console.WriteLine($"Fuel level: {Car.Engine.Volume}");
    }

    public void ShowStatus()
    {
        Console.WriteLine(Car.Engine.IsStarted() ? "Car is started" : "Car isn't started");
    }
}