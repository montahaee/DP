
using src.components;

namespace src.cars
{
    /// <summary>
    /// The Car class (is product class) represents a car with various components.
    /// </summary>
    internal class Car
    {
        private readonly Engine _engine;
        private readonly GPSNavigator _navy;
        private readonly int _seats;
        private readonly CarType _type;
        private readonly Transmission _transmission;
        private readonly TripComputer _tripComputer;

        /// <summary>
        ///Constructs a new Car with the given elements.
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
            _engine = engine;
            _seats = seats;
            _navy = navy;
            _transmission = transmission;
            _tripComputer = tripComputer;
            _type = type;
        }
        public Engine engine => _engine;


        public int Seats => _seats;

        public Transmission transmission => _transmission;

        public TripComputer tripComputer => _tripComputer;
        public CarType type => _type;
        public GPSNavigator navy => _navy;


    }
}
