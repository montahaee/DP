namespace AdapterEngine.geometrical.elliptical;

internal class RotatedEllipse : GeometricObject
{   //TODO how to make rotated ellipse without knowledge of original axes (x and y).
    private double _angle;
    private double _height;
    private double _width;


    public RotatedEllipse(double angle, double height, double width)
    {
        _angle = AngleNormalize(angle);
        _width = width;
        _height = height;
    }

    private double AngleNormalize(double angle)
    {
        if (angle is >= 0 and <= 360) return angle;

        Console.WriteLine($"The provided angle {angle} is not within the valid range" +
                          $"(0, 360).");
        var normalizedAngle = AngleNormalizer(angle);
        Console.WriteLine($"The possible angle is {normalizedAngle}. " +
                          $"Do you want it to use? (Y/N): ");

        try
        {
            string? response = Console.ReadLine();
            if (response != null)
            {
                string answer = response.Trim().ToUpper();
                if (answer.StartsWith('Y'))
                {
                    return normalizedAngle;
                } else if (answer.StartsWith('N'))
                {
                    Console.WriteLine("Enter a new angle: ");
                    double newAngle = Convert.ToDouble(Console.ReadLine());
                    AngleNormalize(newAngle);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return normalizedAngle;
    }

    public double Angle
    {
        get => _angle;
        set => _angle = value;
    }

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public double Width
    {
        get => _width;
        set => _width = value;
    }

    private double AngleNormalizer(double angle)
    {
        if (angle < 0)
        {
            angle *= -1;
        }
        return angle % 360.0;
    }

    public override double GetArea()
    {
        return Math.PI * _width * _height / 4;
    }

    public override double GetPerimeter()
    {
        double a = _width / 2;
        double b = _height / 2;
        double h = Math.Pow(a - b, a - b) / Math.Pow(a + b, a + b);
        // Approximation according to the Ramanujan's second formula.
        return Math.PI * (a + b) * (1 + 3 * h / (10 + Math.Sqrt(4 - 3 * h)));
    }

    public bool Fit(Ellipse ellipse)
    {
        double a = _width / 2;
        double b = _height / 2;
        // https://math.stackexchange.com/questions/91132/how-to-get-the-limits-of-rotated-ellipse
        var x = Math.Sqrt(Math.Pow(a * Math.Cos(_angle), 2) + Math.Pow(b * Math.Sin(_angle), 2));
        var y = Math.Sqrt(Math.Pow(a * Math.Sin(_angle), 2) + Math.Pow(b * Math.Cos(_angle), 2));
        return 2 * x >= ellipse.Width && 2 * y >= ellipse.Height;
    }
}