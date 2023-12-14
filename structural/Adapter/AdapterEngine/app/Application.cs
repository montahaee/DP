using System.Data;
using AdapterEngine.geometrical;
using AdapterEngine.geometrical.elliptical;

namespace AdapterEngine.app;

internal class Application : Form
{
    // TODO drawing and filling objects regarding adaptivity.
    private readonly List<GeometricObject> _geometricObjects = new List<GeometricObject>();

    public Application()
    {
    }
    
    public Application(List<GeometricObject> geometricObjects)
    {
        var geos = geometricObjects.OrderBy(oj => oj.GetArea()).ToList();
        _geometricObjects.AddRange(geometricObjects);
    }

    public void AddGeometry(GeometricObject go)
    {
        if (!_geometricObjects.Any())
        {
            _geometricObjects.Add(go);
        }
        else
        {
            for (int i = 0; i < _geometricObjects.Count; i++)
            {
                if ((_geometricObjects[i].GetArea() <= go.GetArea()))
                {
                    continue;
                }
                _geometricObjects.Insert(i, go);
                break;
            }
        }
    }
    
    //TODO using the following  method plus the fit from Rotatedellipse to adapter scenario.

    private Tuple<List<RotatedEllipse>, List<GeometricObject>> RotatedEllipticalExtraction(List<GeometricObject> geos)
    {
        List<RotatedEllipse> roList = new List<RotatedEllipse>();
        List<GeometricObject> norList = new List<GeometricObject>();
        geos.ForEach(geo =>
        {
            if (geo is RotatedEllipse re)
            {
                roList.Add(re);
            }
            else
            {
                norList.Add(geo);
            }
        });
        return Tuple.Create(roList, norList);
    }



}