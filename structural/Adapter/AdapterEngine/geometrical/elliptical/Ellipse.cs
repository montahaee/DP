﻿namespace AdapterEngine.geometrical.elliptical;

internal class Ellipse : GeometricObject
{
    /**
     * Notice
     */
    private readonly double _width;
    private readonly double _height;

    protected Ellipse()
    {
    }
    [Obsolete("Analytically the width and height are two times of semi-major axes")]
    protected Ellipse(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double Width => _width;

    public double Height => _height;

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
}