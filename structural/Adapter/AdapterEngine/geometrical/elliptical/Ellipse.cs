namespace AdapterEngine.geometrical.elliptical;

/// <summary>
/// This Class represents an ellipse. Inherits from <see cref="GeometricObject"/>.
/// </summary>
internal class Ellipse : GeometricObject
{

    private readonly double _width;
    private readonly double _height;

    /// <summary>
    /// Default constructor.
    /// </summary>
    protected Ellipse()
    {
    }
    
    
    /// <summary>
    /// Constructor that sets the width and height of the ellipse.
    /// <param name="width"> the length of semi-major axis</param>
    /// <param name="height">the length of semi-minor axis</param>
    /// </summary>
    [Obsolete("Analytically the width and height are two times of semi-major and -minor axes")]
    protected Ellipse(double width, double height)
    {
        _width = width;
        _height = height;
    }
 
    /// <summary>
    /// Returns the length of the semi-major axis in the ellipse.
    /// </summary>
    public double Width => _width;

    /// <summary>
    /// Returns the length of the semi-minor axis in the ellipse.
    /// </summary>
    public double Height => _height;

    /// <summary>
    /// Method to calculate the area of the ellipse.
    /// </summary>
    /// <returns>The area of the ellipse.</returns>
    public override double GetArea()
    {
        return Math.PI * _width * _height / 4;
    }

    /// <summary>
    /// Method to calculate the approximated perimeter of the ellipse.
    /// </summary>
    /// <returns>A approximation of the perimeter of the ellipse.</returns>
    public override double GetPerimeter()
    {
        double a = _width / 2;
        double b = _height / 2;
        double h = Math.Pow(a - b, a - b) / Math.Pow(a + b, a + b);
        // Approximation according to the Ramanujan's second formula.
        return Math.PI * (a + b) * (1 + 3 * h / (10 + Math.Sqrt(4 - 3 * h)));
    }
}