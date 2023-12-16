namespace AdapterEngine.geometrical.rectangular;

internal class Rectangle : GeometricObject
{
    private double _width;
    private double _length;

    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }

    public double Width
    {
        get => _width;
        set => _width = value;
    }

    public double Length
    {
        get => _length;
        set => _length = value;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

    public override double GetPerimeter()
    {
        return 2 * (_length + _width);
    }
}