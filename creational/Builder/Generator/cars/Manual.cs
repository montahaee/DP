using Generator.components;

namespace Generator.cars;

/// <summary>
///     The Manual class represents a manual for a car.
///     Car manual is another product. Note that it does not
///     have the same ancestor as a Car.They are not related.
///     The manual describes every feature of the car, so the
///     details in the manuals vary across the different models.
///     So each car should have a user manual that corresponds
///     to the car's configuration and describes all its features.
/// </summary>
internal class Manual
{
    /// <summary>
    ///     The explicit constructor to make new instance of the Manual.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="seats"></param>
    /// <param name="engine"></param>
    /// <param name="transmission"></param>
    /// <param name="tripComputer"></param>
    /// <param name="gpsNavigator"></param>
    public Manual(CarType type, int seats, Engine engine, Transmission transmission,
        TripComputer tripComputer, GPSNavigator gpsNavigator)
    {
        Type = type;
        Seats = seats;
        Engine = engine;
        Transmission = transmission;
        TripComputer = tripComputer;
        GpsNavigator = gpsNavigator;
    }

    public CarType Type { get; }

    public int Seats { get; }

    public Engine Engine { get; }

    public Transmission Transmission { get; }

    public TripComputer TripComputer { get; }

    public GPSNavigator GpsNavigator { get; }

    /// <summary>
    ///     Prints the details of the car manual.
    /// </summary>
    /// <returns>The the details of the car manual as a string.</returns>
    public string Print()
    {
        return $"_type of car: {Type}\n" +
               $"Count of _seats: {Seats}\n" +
               $"_engine: volume - {Engine.Volume}; mileage - {Engine.Mileage(1000.0)}\n" +
               $"_transmission: {Transmission}\n" +
               "Trip Computer: Functional\n" +
               "GPS Navigator: Functional\n";
    }
}