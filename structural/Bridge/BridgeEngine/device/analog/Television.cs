using System;

namespace BridgeEngine.device.analog;

// TODO Visualization this class and Radio. Add Method AMFrequency method to Radio.

public class Television : AnalogCommunication
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
    
    // private bool _on = false;
    // private int _volume = 38;
    // private int _chanel = 1;
    private Pixel _pixel = new Pixel(1920, 1080);
    
    // public bool IsEnabled()
    // {
    //     return _on;
    // }
    //
    // public void Enable()
    // {
    //     _on = true;
    // }
    //
    // public void Disabled()
    // {
    //     _on = false;
    // }
    //
    // public int Volume
    // {
    //     get => _volume;
    //     set => _volume = value > 100 ? 100 : value < 0 ? 0 : value;
    // }

    public override uint Chanel
    {
        get => (uint)((Frequency - 54.0) / 6.0);
        set
        {
            double newFrequency = value * 6.0 + 54.0;
            Frequency = newFrequency;
        }
    }

    public Pixel DisplayResolution
    {
        get => _pixel;
        set => _pixel = value is { Height: < 128, Width: < 128 } ? new Pixel(128, 128) : 
            value.Height < 128 ? new Pixel(value.Width, 128) : 
            value.Width < 128 ? new Pixel(128, value.Height) : value;
    }
    
    public override void DisplayStatus()
    {
        Console.WriteLine($"Enabled: {IsEnabled()}, Volume: {Volume}, Chanel: {Chanel}, " +
                          $"Frequency: {Frequency} MHZ and Resolution: {_pixel.ToString()} .");
    }
    
    protected override void ValidateFrequency(double frequency)
    {
        if (frequency < 54.0 || frequency > 689.0)
        {
            throw new ArgumentOutOfRangeException("Chanel must correspond to a frequency " +
                                                  "between 54.0 and 698.0 MHZ.");
        }
    }
}