

namespace PrototypeCore.shapes;

public abstract class Shape
{

    
    internal int X { get; set; }

    internal int Y { get; set; }

    internal Color Color { get; init; }

    protected Shape()
    {
        
    }
    
    protected Shape(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }
    
    protected Shape(Shape? target)
    {
        if (target != null)
        {
            this.X = target.X;
            this.Y = target.Y;
            this.Color = target.Color;
        }
    }

    protected virtual int GetWidth()
    {
        return 0;
    }

    protected virtual int GetHeight()
    {
        return 0;
    }

     public void Move(int x, int y)
     {
         X += x;    
         Y += y;
     }

     public abstract Shape Clone();

     public override bool Equals(object? obj)
     {
         if (!(obj is Shape shape))
         {
             return false;
         }

         return this.X == shape.X && 
                this.Y == shape.Y &&
                Equals(shape.Color, this.Color);
     }

     public override int GetHashCode()
     {
         return HashCode.Combine(Color);
     }

     protected virtual void Paint(Graphics graphics)
     {
         Pen pen = new Pen(Color);
         graphics.DrawRectangle(pen, new System.Drawing.Rectangle(X, Y, this.GetWidth(), this.GetHeight() ));
     }


}