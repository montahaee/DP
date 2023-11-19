
using src.cars;

namespace src.components
{
    internal class TripComputer
    {

        private Car _car { get => _car; set => _car = value; }

        public void ShowFuelLevel() => Console.WriteLine($"Fuel level: {_car.engine.Volume}");

        public Car car { get { return _car; } set { _car = value; } }

        public void ShowStatus()
        {
            if (_car.engine.IsStarted())  
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }

        }
    }
}
