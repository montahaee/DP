namespace PrototypeCore.shapes;

public class Circle : Shape
{
    internal int Radius { get; set; }

    public Circle()
    {
        
    }

    public Circle(Circle? target) : base(target)
    {
        if (target != null)
        {
            this.Radius = target.Radius;
        }
    }
    
    public override Shape Clone()
    {
        return new Circle(this);
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Circle shape) || !base.Equals(obj))
        {
            return false;
        }
        return shape.Radius == this.Radius;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Radius);
    }

    protected override int GetWidth()
    {
        return 2*Radius;
    }

    protected override int GetHeight()
    {
        return 2*Radius;
    }

    protected override void Paint(Graphics graphics) 
    {
        base.Paint(graphics);
        var pen = new Pen(Color);
        graphics.DrawEllipse(pen, X, Y, GetWidth() - 1, GetHeight() - 1);
        pen.Dispose();
        
    }
}