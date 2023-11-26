namespace PrototypeCore.shapes;

/// <summary>
/// Concrete prototype class. The cloning methode creates
/// a new object and passes it to the constructor<seealso cref="Clone"/>.
/// Until the  constructor is finished, it has a reference to a fresh clone.
/// Therefore, nobody has access to a partly-built clone.
/// This keeps the cloning result consistent. 
/// </summary>
public class Circle : Shape
{
    private int _radius; 

    public Circle()
    {
        
    }

    public Circle(Circle? target) : base(target)
    {
        if (target != null)
        {
            this._radius = target._radius;
        }
    }
    
    public override Shape Clone()
    {
        return new Circle(this);
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is  Circle shape) || !base.Equals(obj))
        {
            return false;
        }
        return shape._radius == this._radius;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), _radius);
    }

    protected override int GetWidth()
    {
        return 2*_radius;
    }

    protected override int GetHeight()
    {
        return 2*_radius;
    }

    internal override void Paint(Graphics graphics) 
    {
        base.Paint(graphics);
        var pen = new Pen(Color);
        graphics.DrawEllipse(pen, X, Y, GetWidth() - 1, GetHeight() - 1);
        pen.Dispose();
        
    }
    
    /// <summary>
    /// The getter and setter for radius of the circle object. 
    /// </summary>
    public int Radius
    {
        get => _radius;
        set => _radius = value;
    }
}