namespace PrototypeCore.shapes;

public class Rectangle : Shape
{
    internal int Width { get; init; }
    internal int Height { get; init; }

    public Rectangle()
    {
        
    }

    public Rectangle(Rectangle? target) : base(target)
    {
        if (target != null)
        {
            this.Width = target.Width;
            this.Height = target.Height;
        }
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }

    protected override int GetWidth()
    {
        return Width;
    }

    protected override int GetHeight()
    {
        return Height;
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Rectangle shape) || !base.Equals(obj))
        {
            return false;
        }

        return shape.Height == this.Height && shape.Width == this.Width;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Width, Height);
    }

    protected override void Paint(Graphics graphics)
    {
        base.Paint(graphics);
        Pen pen = new Pen(Color);
        graphics.DrawRectangle(pen, X, Y, GetWidth() - 1, GetHeight() - 1);
        pen.Dispose();
    }
}