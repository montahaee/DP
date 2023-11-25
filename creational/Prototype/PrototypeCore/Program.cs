
using PrototypeCore.shapes;
using Rectangle = PrototypeCore.shapes.Rectangle;

namespace PrototypeCore;

internal static class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        List<Shape> shapesCopy = new List<Shape>();

        Circle circle = new Circle
        {
            X = 10,
            Y = 20,
            Radius = 15,
            Color = Color.Red
        };
        shapes.Add(circle);

        Circle otherCircle = (Circle)circle.Clone();
        shapes.Add(otherCircle);

        Rectangle rectangle = new Rectangle
        {
            Width = 10,
            Height = 20,
            Color = Color.Blue
        };
        shapes.Add(rectangle);
    }

    private static void CloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy)
    {
        shapes.ForEach(shape =>
        {
            shapesCopy.Add(shape.Clone());
        });
        
        for (int i = 0; i < shapes.Count; i++) {
            if (!ReferenceEquals(shapes[i], shapesCopy[i]))
            {
                Console.WriteLine($"{i}: Shapes are different objects (yay!)");
                Console.WriteLine(shapes[i].Equals(shapesCopy[i])
                    ? $"{i}: And they are identical (yay!)"
                    : $"{i}: But they are not identical (booo!)");
            } else {
                Console.WriteLine($"{i}: Shape objects are the same (booo!)");
            }
        }
        
    }
}