namespace AdapterEngine.geometrical;

/// <summary>
/// Abstract base class for geometric objects.
/// </summary>
public abstract class GeometricObject
{
    /// <summary>
    /// Default constructor.
    /// </summary>
    protected GeometricObject()
    {
        
    }
    
    /// <summary>
    /// Explicit constructor that sets the filled property.
    /// </summary>
    protected GeometricObject(bool filled)
    {
        IsFilled = filled;
    }

    /// <summary>
    /// Property indicating whether the object is filled.
    /// </summary>
    public bool IsFilled { get; set; }

    /// <summary>
    /// Abstract method to calculate the area of the object.
    /// </summary>
    public abstract double GetArea();

    /// <summary>
    /// Abstract method to calculate the perimeter of the object.
    /// </summary>
    public abstract double GetPerimeter();
}