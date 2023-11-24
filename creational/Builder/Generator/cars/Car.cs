using Generator.components;

namespace Generator.cars;

/// <summary>
///     The Car class (is product class) represents a car with various components.
/// </summary>
internal class Car
{
    /// <summary>
    ///     Constructs a new Car with the given elements.
    /// </summary>
    /// <param name="engine"></param>
    /// <param name="navy"></param>
    /// <param name="seats"></param>
    /// <param name="transmission"></param>
    /// <param name="tripComputer"></param>
    /// <param name="type"></param>
    public Car(Engine engine, GPSNavigator navy, int seats, Transmission transmission,
        TripComputer tripComputer, CarType type)
    {
        Engine = engine;
        Seats = seats;
        Navy = navy;
        Transmission = transmission;
        TripComputer = tripComputer;
        Type = type;
    }

    public Engine Engine { get; }


    public int Seats { get; }

    public Transmission Transmission { get; }

    public TripComputer TripComputer { get; }

    public CarType Type { get; }

    public GPSNavigator Navy { get; }
}