using src.builders;
using src.cars;
using src.components;

namespace src.director
{
    /// <summary>
    /// The Director class is responsible for constructing cars. 
    /// It defines the order of building steps and works with
    /// a builder object through common <seealso cref="IBuilder"/> interface.
    /// </summary>
    internal class Director
    {
        /// <summary>
        /// Constructs a sports car.
        /// </summary>
        /// <param name="builder"></param>
        public void constructSportsCar(IBuilder builder) {
            builder.setType(CarType.SPORTS_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(Engine.EngineType.ICE, 7.0, 0.0));
            builder.setTransmission(new SemiAutomaticTransmission());
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        /// <summary>
        /// Constructs a city car.
        /// </summary>
        /// <param name="builder"></param>
        public void constructCityCar(IBuilder builder) {
            builder.setType(CarType.CITY_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(Engine.EngineType.EM, 3.0, 0.0));
            builder.setTransmission(new AutomaticTransmission());
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        /// <summary>
        /// Constructs a SUV car.
        /// </summary>
        /// <param name="builder"></param>
        public void constructSUV(IBuilder builder)
        {
            builder.setType(CarType.SUV);
            builder.setSeats(4);
            builder.setEngine(new Engine(Engine.EngineType.NGE, 5.7, 0.0));
            builder.setTransmission(new ManualTransmission());
            builder.setGPSNavigator(new GPSNavigator());
        }
    }
}
