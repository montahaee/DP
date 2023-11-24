using Generator.builders;
using Generator.director;

namespace Generator;

/// <summary>
///     The Program class contains the main entry point of the program as a demonstration.
/// </summary>
internal static class Program
{
    /// <summary>
    ///     The main entry point of the program.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        var director = new Director();
        var builder = new CarBuilder();
        director.ConstructSportsCar(builder);
        var car = builder.Output();
        Console.WriteLine("Car built:\n" + car.GetType());
        var manual = new CarManualBuilder();
        director.ConstructSportsCar(manual);
        var carManual = manual.Output();
        Console.WriteLine("\nCar manual built:\n" + carManual.Print());
    }
}