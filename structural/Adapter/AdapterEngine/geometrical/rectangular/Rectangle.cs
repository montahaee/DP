namespace AdapterEngine.geometrical.rectangular;

/// <summary>
/// Class representing a rectangle as <see cref="GeometricObject"/>.
/// 
/// </summary>
internal class Rectangle : GeometricObject
{
    private double _width;
    private double _length;

    /// <summary>
    /// Explicit constructor that sets the width and length of the rectangle.
    /// </summary>
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }

    /// <summary>
    /// Return or set the width of the rectangle.
    /// </summary>
    public double Width
    {
        get => _width;
        set => _width = value;
    }

    /// <summary>
    /// Return or set the length of the rectangle.
    /// </summary>
    public double Length
    {
        get => _length;
        set => _length = value;
    }

    /// <summary>
    /// Method to calculate the area of the rectangle.
    /// </summary>
    public override double GetArea()
    {
        return _length * _width;
    }

    
    /// <summary>
    /// Method to calculate the perimeter of the rectangle.
    /// </summary>
    public override double GetPerimeter()
    {
        return 2 * (_length + _width);
    }
}