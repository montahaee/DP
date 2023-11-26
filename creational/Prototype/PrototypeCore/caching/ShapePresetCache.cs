using PrototypeCore.shapes;
using Rectangle = PrototypeCore.shapes.Rectangle;

namespace PrototypeCore.caching;

/// <summary>
/// This class stores a cache of pre-configured shapes.
/// </summary>
public class ShapePresetCache
{
    private readonly Dictionary<string, Shape> _caches = new Dictionary<string, Shape>();

    public ShapePresetCache()
    {
        Circle circle = new Circle
        {
            X = 5,
            Y = 7,
            Radius = 35,
            Color = Color.Chocolate
        };
        Rectangle rectangle = new Rectangle()
        {
            X = 6,
            Y = 9,
            Width = 8,
            Height = 10,
            Color = Color.Bisque
        };
        _caches.Add("Big Chocolate Circle", circle);
        _caches.Add("Medium Bisque Rectangle", rectangle);
    }

    /// <summary>
    /// This method adds a shape to the cache or updates an existing shape.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="shape"></param>
    /// <returns></returns>
    public Shape Put(string key, Shape shape)
    {
        _caches[key] = shape;
        return shape;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key">the key whose value will be modified.</param>
    /// <returns> a clone of the shape to prevent modifications to the original shape</returns>
    public Shape Get(string key)
    {
        return _caches[key].Clone();
    }

    /// <summary>
    /// This property provides access to the cache.git 
    /// </summary>
    public Dictionary<string, Shape> Caches => _caches;
}