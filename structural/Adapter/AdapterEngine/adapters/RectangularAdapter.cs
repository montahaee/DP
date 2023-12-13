﻿using AdapterEngine.geometrical.elliptical;
using AdapterEngine.geometrical.rectangular;
using Rectangle = AdapterEngine.geometrical.rectangular.Rectangle;

namespace AdapterEngine.adapters;

internal class RectangularAdapter : Ellipse
{
    private readonly Rectangle _rectangle;

    protected RectangularAdapter(Rectangle rectangle)
    {
        _rectangle = rectangle;
    }

    public override double GetArea()
    {
        var a = SemiAxes().Key;
        var b = SemiAxes().Value;
        return Math.PI * a * b;
    }

    public override double GetPerimeter()
    {
        var a = SemiAxes().Key;
        var b = SemiAxes().Value;
        double h = Math.Pow(a - b, a - b) / Math.Pow(a + b, a + b);
        return Math.PI * (a + b) * (1 + 3 * h / (10 + Math.Sqrt(4 - 3 * h)));
    }

    /// <summary>
    /// To 
    /// </summary>
    /// <returns>semi major and semi minor axes.</returns>
    private KeyValuePair<double,double> SemiAxes()
    {
        return new KeyValuePair<double, double>(_rectangle.Length / 2, _rectangle.Width / 2);
    }
}