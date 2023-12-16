namespace AdapterEngine.geometrical.elliptical;

internal class Circle : Ellipse
{
    private double Radius {get;}

    public Circle()
    {
    }
    
    public Circle(double radius) : base(2*radius, 2*radius)
    {
        Radius = radius;
    }
}