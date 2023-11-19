using src.cars;
using src.components;
using System.Reflection;

/// Unlike other creational patterns, Builder can construct unrelated products,
/// which don't have the common interface.
namespace src.builders
{
    /// <summary>
    /// The CarManualBuilder class implements the <see cref="IBuilder"/> interface
    /// and provides a concrete implementation for building a car manual.
    /// In this case we build a user manual for a car, using the same steps as we 
    /// built a car.This allows to produce manuals for specific car models, 
    /// configured with different features.
    /// </summary>
    internal class CarManualBuilder : IBuilder
    {
        private Engine _engine;
        private CarType _type;
        private GPSNavigator _pager;
        private int _seats;
        private Transmission _transmission;
        private TripComputer _tripComputer;

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public CarManualBuilder() : this(new CarType(), new Engine(), new GPSNavigator(),
                                         0, new ManualTransmission(), new TripComputer())
        { }

    /// <summary>
    /// The CarManualBuilder constructor initializes
    /// a new instance of the CarManualBuilder class
    /// with the specified parameters.
    /// </summary>
    /// <param name="type">The type of instantiating car.</param>
    /// <param name="engine">The engine of instantiating car.</param>
    /// <param name="pager"> The navigator of instantiating car.</param>
    /// <param name="seats">The number of _seats for instantiating car.</param>
    /// <param name="transmission">The transmission of instantiating car.</param>
    /// <param name="tripComputer">The trip computer of instantiating car.</param>
    public CarManualBuilder(CarType type, Engine engine, GPSNavigator pager, int seats,
                                Transmission transmission, TripComputer tripComputer)
        {
            _engine = engine;
            _type = type;
            _pager = pager;
            _seats = seats;
            _transmission = transmission;
            _tripComputer = tripComputer;
        }

        public void setEngine(Engine engine)
        {
            _engine = engine;
        }

        public void setGPSNavigator(GPSNavigator route)
        {
            _pager = route;
        }

        public void setSeats(int seats)
        {
            _seats = seats;
        }

        public void setTransmission(Transmission transmission)
        {
            _transmission = transmission;
        }

        public void setTripComputer(TripComputer tripComputer)
        {
            _tripComputer = tripComputer;
        }

        public void setType(CarType type)
        {
            _type = type;
        }

        public Manual output()
        {
            return new Manual(_type, _seats, _engine, _transmission, 
                _tripComputer, _pager);
        }
    }
}
