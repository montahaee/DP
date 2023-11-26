
using PrototypeCore.caching;
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
        // shapesCopy.AddRange(shapes);
        shapes.ForEach(shape =>
        {
            shapesCopy.Add(shape.Clone());
        });
        CloneAndCompare(shapes, shapesCopy);
        var cache = new ShapePresetCache();
        Shape shape0 = cache.Get("Big Chocolate Circle");
        Shape shape1 = cache.Get("Big Chocolate Circle");
        Shape shape2 = cache.Get("Medium Bisque Rectangle");
        if (!ReferenceEquals(shape0, shape1))
        {
            Console.WriteLine("Big Chocolate Circles are two different objects (yah!)");
            Console.WriteLine(shape0.Equals(shape1) ? 
                    "And they are identical (yah!)" :
                    "But they aren't identical (boo!)");
        }
        else
        {
            Console.WriteLine("The both Circle objects are identical (boo!)");
        }
        Console.WriteLine((!ReferenceEquals(shape1, shape2) && !shape1.Equals(shape2)) 
                ? "Big Chocolate Circles != Medium Bisque Rectangle (yah!)"
                : "Big Chocolate Circles == Medium Bisque Rectangle (boo!)");
    }
    
    /// <summary>
    /// This method compares two lists of shapes to check if they are identical.
    /// </summary>
    /// <param name="shapes"></param>
    /// <param name="shapesCopy"></param>
    private static void CloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy)
    {
        for (int i = 0; i < shapes.Count; i++) {
            if (!ReferenceEquals(shapes[i], shapesCopy[i]))
            {
                Console.WriteLine($"{i}: Shapes are different objects (yah!)");
                Console.WriteLine(shapes[i].Equals(shapesCopy[i])
                    ? $"{i}: And they are identical (yah!)"
                    : $"{i}: But they are not identical (boo!)");
            } else {
                Console.WriteLine($"{i}: Shape objects are the same (boo!)");
                shapes[i].Move(1, 1);
            }
        }
    }
}