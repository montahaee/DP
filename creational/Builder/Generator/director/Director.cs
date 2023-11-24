using Generator.builders;
using Generator.cars;
using Generator.components;

namespace Generator.director;

/// <summary>
///     The Director class is responsible for constructing cars.
///     It defines the order of building steps and works with
///     a builder object through common <seealso cref="IBuilder" /> interface.
/// </summary>
internal class Director
{
    /// <summary>
    ///     Constructs a sports car.
    /// </summary>
    /// <param name="builder"></param>
    public void ConstructSportsCar(IBuilder builder)
    {
        builder.SetType(CarType.SportsCar);
        builder.SetSeats(2);
        builder.SetEngine(new Engine(Engine.EngineType.ICE, 7.0, 0.0));
        builder.SetTransmission(new SemiAutomaticTransmission());
        builder.SetTripComputer(new TripComputer());
        builder.SetGpsNavigator(new GPSNavigator());
    }

    /// <summary>
    ///     Constructs a city car.
    /// </summary>
    /// <param name="builder"></param>
    public void ConstructCityCar(IBuilder builder)
    {
        builder.SetType(CarType.CityCar);
        builder.SetSeats(2);
        builder.SetEngine(new Engine(Engine.EngineType.EM, 3.0, 0.0));
        builder.SetTransmission(new AutomaticTransmission());
        builder.SetTripComputer(new TripComputer());
        builder.SetGpsNavigator(new GPSNavigator());
    }

    /// <summary>
    ///     Constructs a SUV car.
    /// </summary>
    /// <param name="builder"></param>
    public void ConstructSuv(IBuilder builder)
    {
        builder.SetType(CarType.Suv);
        builder.SetSeats(4);
        builder.SetEngine(new Engine(Engine.EngineType.NGE, 5.7, 0.0));
        builder.SetTransmission(new ManualTransmission());
        builder.SetGpsNavigator(new GPSNavigator());
    }
}