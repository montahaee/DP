

namespace PrototypeCore.shapes;

/// <summary>
/// The base prototype class.
/// </summary>
public abstract class Shape
{
    
    internal int X { get; set; }

    internal int Y { get; set; }

    internal Color Color { get; init; }

    /// <summary>
    /// A default constructor.
    /// </summary>
    protected Shape()
    {
        
    }
    
    /// <summary>
    /// The explicit constructor.
    /// </summary>
    /// <param name="x">The horizontal coordinate of the shape constructing.</param>
    /// <param name="y">The vertical coordinate of the shape constructing.</param>
    /// <param name="color">The color of the shape constructing.</param>
    protected Shape(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }
    
    /// <summary>
    /// The prototype copy constructor. A fresh object is initialized
    /// with values from the existing object.
    /// </summary>
    /// <param name="target"></param>
    protected Shape(Shape? target)
    {
        if (target != null)
        {
            this.X = target.X;
            this.Y = target.Y;
            this.Color = target.Color;
        }
    }

    /// <summary>
    /// Width of the shape.
    /// </summary>
    /// <returns>The current width of the shape.</returns>
    protected virtual int GetWidth()
    {
        return 0;
    }

    /// <summary>
    /// Height of the shape.
    /// </summary>
    /// <returns>the current height of the shape.</returns>
    protected virtual int GetHeight()
    {
        return 0;
    }

    /// <summary>
    /// The movement of the shape in 2D coordinate system.
    /// </summary>
    /// <param name="x">The distance to move along the x-axis.</param>
    /// <param name="y">The distance to move along the y-axis.</param>
     public void Move(int x, int y)
     {
         X += x;    
         Y += y;
     }

    /// <summary>
    /// The clone operation.
    /// </summary>
    /// <returns> one of the shape subclasses.</returns>
     public abstract Shape Clone();

    /// <summary>
    /// Determine whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare withe current one.</param>
    /// <returns>true if the specified object is equal
    /// to the current object; otherwise, false.</returns>
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

    /// <summary>
    ///  Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
     public override int GetHashCode()
     {
         return HashCode.Combine(Color);
     }

    /// <summary>
    /// Paints the shape onto the specified Graphics object.
    /// </summary>
    /// <param name="graphics"> The Graphics object to be painted on.</param>
     internal virtual void Paint(Graphics graphics)
     {
         Pen pen = new Pen(Color);
         graphics.DrawRectangle(pen, new System.Drawing.Rectangle(X, Y, this.GetWidth(), this.GetHeight() ));
     }


}