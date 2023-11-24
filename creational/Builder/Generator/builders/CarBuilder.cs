using Generator.cars;
using Generator.components;

namespace Generator.builders;

/// <summary>
///     The CarBuilder class implements the IBuilder interface
///     and provides a concrete implementation for building a car.
/// </summary>
internal class CarBuilder : IBuilder
{
    private Engine _engine;
    private GPSNavigator _nav;
    private int _seats;
    private Transmission _transmission;
    private TripComputer _tripComputer;
    private CarType _type;

    /// <summary>
    ///     The implicit constructor
    /// </summary>
    public CarBuilder() : this(new CarType(), new Engine(), new GPSNavigator(), 0, new SingleSpeedTransmission(),
        new TripComputer())
    {
    }

    /// <summary>
    ///     The CarBuilder constructor initializes
    ///     a new instance of the CarBuilder class
    ///     with the specified parameters.
    /// </summary>
    /// <param name="type">The type of instantiating car.</param>
    /// <param name="engine">The engine of instantiating car.</param>
    /// <param name="nav"> The navigator of instantiating car.</param>
    /// <param name="seats">The number of _seats for instantiating car.</param>
    /// <param name="transmission">The transmission of instantiating car.</param>
    /// <param name="tripComputer">The trip computer of instantiating car.</param>
    public CarBuilder(CarType type, Engine engine, GPSNavigator nav, int seats, Transmission transmission,
        TripComputer tripComputer)
    {
        _engine = engine;
        _nav = nav;
        _seats = seats;
        _transmission = transmission;
        _tripComputer = tripComputer;
        _type = type;
    }

    public void SetEngine(Engine engine)
    {
        _engine = engine;
    }

    public void SetGpsNavigator(GPSNavigator route)
    {
        _nav = route;
    }

    public void SetSeats(int seats)
    {
        _seats = seats;
    }

    public void SetTransmission(Transmission transmission)
    {
        _transmission = transmission;
    }

    public void SetTripComputer(TripComputer tripComputer)
    {
        _tripComputer = tripComputer;
    }

    public void SetType(CarType type)
    {
        _type = type;
    }

    /// <summary>
    ///     The final part is fetching the resulting object. A metal car
    ///     (<see cref="CarManualBuilder" />) and a paper manual, although related,
    ///     are still very different things.
    /// </summary>
    /// <returns></returns>
    public Car Output()
    {
        return new Car(_engine, _nav, _seats, _transmission, _tripComputer, _type);
    }
}