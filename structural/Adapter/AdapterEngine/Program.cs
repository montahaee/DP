
using AdapterEngine.app;
using AdapterEngine.geometrical;
using AdapterEngine.geometrical.elliptical;
using AdapterEngine.geometrical.rectangular;
using Rectangle = AdapterEngine.geometrical.rectangular.Rectangle;

namespace AdapterEngine
{
    /// <summary>
    /// This class is to demonstrate the functionality of the all program.
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Create a list to hold geometric objects
            List<GeometricObject> geometricObjects = new List<GeometricObject>();
            Square square = new Square(3.75);
            geometricObjects.Add(square);
            
            RotatedEllipse rotatedEllipse = new RotatedEllipse(30, 4.2, 6.3);
            geometricObjects.Add(rotatedEllipse);
            
            Rectangle rectangle = new Rectangle(2.4, 4.8);
            geometricObjects.Add(rectangle);

            Circle circle = new Circle(2.8);
            geometricObjects.Add(circle);
            
            // Create a DiagramApplication with the list of geometric and run it.
            DiagramApplication app = new DiagramApplication(geometricObjects);
            Application.Run(app);
        }
    }  
}

    

