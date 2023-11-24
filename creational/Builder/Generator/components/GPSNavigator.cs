namespace Generator.components;

internal class GPSNavigator
{
    public GPSNavigator() :
        this("22lb, Baker Street, London to Scotland Yard, 8-10 Broadway, London") //TODO write default navigator
    {
    }

    public GPSNavigator(string route)
    {
        this.route = route;
    }

    public string route { get; }
}