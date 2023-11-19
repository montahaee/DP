
namespace src.components
{
    /// <summary>
    /// The _engine class represents an engine with different types and properties.
    /// </summary>
    internal class Engine
    {
       public enum EngineType
       { 
            ICE, // Internal Combustion _engine
            EM,  // Electric Motor
            NGE, // Natural Gas _engine
            RE   // Rotary _engine
        }

        private double _distanceTravelled;
        private EngineType _engType { get; }
        private double _volume;

        /// <summary>
        /// The implicit constructor of _engine.
        /// </summary>
        public Engine() : this(new EngineType(), 0.0, 0.0) { }

        /// <summary>
        /// Initializes a new instance of the _engine class with the specified parameters.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="volume"></param>
        /// <param name="distanceTravelled"></param>
        public Engine (EngineType type, double volume, double distanceTravelled)
        {
            _engType = type;
            _volume = volume;
            _distanceTravelled = distanceTravelled;
        }

        /// <summary>
        /// Gets the distance travelled by the engine.
        /// </summary>
        public double DistanceTravelled { get => _distanceTravelled; }

        /// <summary>
        /// Gets the type of the engine.
        /// </summary>
        public EngineType Type { get => _engType; }

        /// <summary>
        /// Gets the volume of the engine.
        /// </summary>
        public double Volume { get => _volume; }

        /// <summary>
        /// Determines whether the engine is started.
        /// </summary>
        /// <returns>true if it is started.</returns>
        public bool IsStarted ()
        {
            return (_distanceTravelled/_volume) - 1 > 0.0;
        }

        /// <summary>
        /// Calculates the mileage of the engine based on the fuel consumed.
        /// </summary>
        /// <param name="fuelConsumed"></param>
        /// <returns> The milage of the engine.</returns>
        /// <exception cref="ArgumentException"></exception>
        public double Mileage(double fuelConsumed) {
            double efficiencyFactor;
            switch (_engType) { 
                case EngineType.ICE:
                    efficiencyFactor = 0.3;
                    break;
                case EngineType.EM:
                    efficiencyFactor = 0.95;
                    break;
                case EngineType.NGE:
                    efficiencyFactor = 0.4;
                    break;
                case EngineType.RE:
                    efficiencyFactor = 0.35;
                    break;
                default:
                    throw new ArgumentException("Unknown engine type");
            }
            return efficiencyFactor * _distanceTravelled / fuelConsumed;
        }

    }
}
