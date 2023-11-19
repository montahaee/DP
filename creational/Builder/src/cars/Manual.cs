
using src.components;

namespace src.cars
{
    /// <summary>
    /// The Manual class represents a manual for a car.
    /// Car manual is another product. Note that it does not
    /// have the same ancestor as a Car.They are not related.
    /// The manual describes every feature of the car, so the 
    /// details in the manuals vary across the different models.
    /// So each car should have a user manual that corresponds
    /// to the car's configuration and describes all its features.
    /// </summary>
    internal class Manual
    {
        private CarType _type { get; }
        private int _seats { get; }
        private Engine _engine { get; }
        private Transmission _transmission { get; }
        private TripComputer _tripComputer { get; }
        private GPSNavigator _gpsNavigator { get; }

        /// <summary>
        /// The explicit constructor to make new instance of the Manual.
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
            this._type = type;
            this._seats = seats;
            this._engine = engine;
            this._transmission = transmission;
            this._tripComputer = tripComputer;
            this._gpsNavigator = gpsNavigator;
        }

        /// <summary>
        /// Prints the details of the car manual.
        /// </summary>
        /// <returns>The the details of the car manual as a string.</returns>
        public string Print() =>
            $"_type of car: {_type}\n" +
            $"Count of _seats: {_seats}\n" +
            $"_engine: volume - {_engine.Volume}; mileage - {_engine.Mileage(1000.0)}\n" +
            $"_transmission: {_transmission}\n" +
            $"Trip Computer: {(_tripComputer != null ? "Functional" : "N/A")}\n" +
            $"GPS Navigator: {(_gpsNavigator != null ? "Functional" : "N/A")}\n";
    }

}
