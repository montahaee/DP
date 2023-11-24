using Generator.cars;
using Generator.components;

namespace Generator.builders;

/// <summary>
///     The IBuilder interface defines the methods that
///     a builder class must implement to construct a car.
///     It defines all possible ways to configure a product.
/// </summary>
internal interface IBuilder
{
    /// <summary>
    ///     Sets the type of the car.
    /// </summary>
    /// <param name="type">
    ///     The type of the car to be set.
    /// </param>
    void SetType(CarType type);

    /// <summary>
    ///     Sets the number of _seats in the car.
    /// </summary>
    /// <param name="seats">
    ///     The number of _seats to be set.
    /// </param>
    void SetSeats(int seats);

    /// <summary>
    ///     Sets the engine of the car.
    /// </summary>
    /// <param name="engine">
    ///     The engine of the car to be set.
    /// </param>
    void SetEngine(Engine engine);

    /// <summary>
    ///     Sets the transmission of the car.
    /// </summary>
    /// <param name="transmission">
    ///     The transmission of the car to be set.
    /// </param>
    void SetTransmission(Transmission transmission);

    /// <summary>
    ///     Sets the trip computer of the car.
    /// </summary>
    /// <param name="tripComputer">
    ///     The trip computer of the car to be set.
    /// </param>
    void SetTripComputer(TripComputer tripComputer);

    /// <summary>
    ///     Sets the GPS navigator of the car.
    /// </summary>
    /// <param name="route">
    ///     The the GPS navigator of the car to be set.
    /// </param>
    void SetGpsNavigator(GPSNavigator route);
}