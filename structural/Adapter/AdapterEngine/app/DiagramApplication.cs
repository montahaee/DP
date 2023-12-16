using System.Data;
using AdapterEngine.adapters;
using AdapterEngine.geometrical;
using AdapterEngine.geometrical.elliptical;
using AdapterEngine.geometrical.rectangular;
using Rectangle = AdapterEngine.geometrical.rectangular.Rectangle;

namespace AdapterEngine.app;

internal class DiagramApplication : Form
{
    // TODO drawing and filling objects regarding adaptivity.
    private readonly List<GeometricObject> _geometricObjects = new List<GeometricObject>();

    public DiagramApplication()
    {
    }
    
    public DiagramApplication(List<GeometricObject> geometricObjects)
    {
        var geos = geometricObjects.OrderBy(geo => geo.GetArea()).ToList();
        _geometricObjects.AddRange(geometricObjects);
        this.Paint += new PaintEventHandler(DrawGeometricObject!);
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

    
    private void DrawGeometricObject(Object sender, PaintEventArgs e)
    {
        var partitions = PartitionByRotatedEllipse(_geometricObjects);
        var adapters = Adapters(partitions.Item2);
        var fits = DrawableObjects(partitions.Item1, adapters);
        var g = e.Graphics;

        foreach (RotatedEllipse ellipse in fits.Keys)
        {
            g.FillEllipse(Brushes.Brown, 0, 0, (float)ellipse.Width, (float)ellipse.Height);
            ellipse.IsFilled = true;
            var rectangles = fits[ellipse];
            rectangles.ForEach(rectangle =>
            {
                if (!rectangle.IsFilled)
                {
                    g.FillRectangle(Brushes.Blue, 0, 0, (float) rectangle.Figure.Length,
                        (float)rectangle.Figure.Width);
                    rectangle.IsFilled = true;
                }
                else
                {
                    Console.WriteLine($"The geometric Object {rectangle.GetType().ToString()} is already displayed!");
                }
            });
        }
        
        
    }

    private Dictionary<RotatedEllipse, List<RectangularAdapter>> DrawableObjects(
        List<RotatedEllipse> rotatedEllipses, List<RectangularAdapter> rectangularAdapters)
    {
        Dictionary<RotatedEllipse, List<RectangularAdapter>> fits =
            new Dictionary<RotatedEllipse, List<RectangularAdapter>>();
            
        rotatedEllipses.ForEach(ellipse =>
        {
            rectangularAdapters.ForEach(rectangle =>
            {
                if (ellipse.Fit(rectangle))
                {
                    Console.WriteLine($"The rectangle with the width {rectangle.Height} " +
                                      $"and length {rectangle.Width} fits rotated ellipse " +
                                      $"with height {ellipse.Height} and width {ellipse.Width}. ");
                    if (!fits.ContainsKey(ellipse))
                    {
                        fits[ellipse] = new List<RectangularAdapter>();
                    }
                    fits[ellipse].Add(rectangle);
                }
            });
        });
        return fits;
    }
    
    private List<RectangularAdapter> Adapters(List<GeometricObject> geos)
    {
        List<RectangularAdapter> adapters = new List<RectangularAdapter>();
        geos.ForEach(geo =>
        {
            if (geo is RectangularAdapter rec)
            {
                adapters.Add(rec);
            }
        } );
        return adapters;
    }
    
    private Tuple<List<RotatedEllipse>, List<GeometricObject>> PartitionByRotatedEllipse(List<GeometricObject> geos)
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