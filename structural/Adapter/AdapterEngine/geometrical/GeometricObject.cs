namespace AdapterEngine.geometrical;

public abstract class GeometricObject
{
    protected GeometricObject()
    {
        
    }
    
    protected GeometricObject(bool filled)
    {
        IsFilled = filled;
    }

    public bool IsFilled { get; set; }

    public abstract double GetArea();

    public abstract double GetPerimeter();
}