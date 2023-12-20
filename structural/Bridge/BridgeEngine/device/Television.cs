using System.Collections.Generic;

namespace BridgeEngine.device;

// TODO Visualization this class and Radio. Add Method AMFrequency method to Radio.

public class Television : IDevice
{
    public struct Pixel
    {
        private uint _width;
        private uint _height;

        public Pixel(uint width, uint height)
        {
            _width = width;
            _height = height;
        }

        public uint Width
        {
            get => _width;
            set => _width = value;
        }

        public uint Height
        {
            get => _height;
            set => _height = value;
        }

        public override string ToString()
        {
            return $"{_width}x{_height}";
        }
    }
    
    private bool _on = false;
    private int _volume = 38;
    private uint _chanel = 1;
    private Pixel _pixel = new Pixel(1920, 1080);
    
    public bool IsEnabled()
    {
        return _on;
    }

    public void Enable()
    {
        _on = true;
    }

    public void Disabled()
    {
        _on = false;
    }

    public int Volume
    {
        get => _volume;
        set => _volume = value > 100 ? 100 : value < 0 ? 0 : value;
    }

    public uint Chanel
    {
        get => _chanel;
        set => _chanel = value > 100 ? 100 : value;
    }

    public Pixel DisplayResolution
    {
        get => _pixel;
        set => _pixel = value is { Height: < 128, Width: < 128 } ? new Pixel(128, 128) : 
            value.Height < 128 ? new Pixel(value.Width, 128) : 
            value.Width < 128 ? new Pixel(128, value.Height) : value;
    }
    
    public void DisplayStatus()
    {
        throw new System.NotImplementedException();
    }
}