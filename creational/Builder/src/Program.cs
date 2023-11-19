
using src.builders;
using src.cars;
using src.director;

namespace src
{
    /// <summary>
    /// The Program class contains the main entry point of the program as a demonstration.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Director director = new Director();
            CarBuilder builder = new CarBuilder();
            director.constructSportsCar(builder);
            Car car = builder.output();
            Console.WriteLine("Car built:\n" + car.GetType());
            CarManualBuilder manual = new CarManualBuilder();
            director.constructSportsCar(manual);
            Manual carManual = manual.output();
            Console.WriteLine("\nCar manual built:\n" + carManual.Print());
        }
    }

}