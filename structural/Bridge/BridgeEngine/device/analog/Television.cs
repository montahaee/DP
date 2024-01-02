namespace BridgeEngine.device.analog;

// TODO Visualization this class and Radio. Add Method AMFrequency method to Radio.

public class Television : AnalogCommunication
{
    // private bool _on = false;
    // private int _volume = 38;
    // private int _chanel = 1;
    private Pixel _pixel = new(1920, 1080);

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
            var newFrequency = value * 6.0 + 54.0;
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
            throw new ArgumentOutOfRangeException("Chanel must correspond to a frequency " +
                                                  "between 54.0 and 698.0 MHZ.");
    }

    public struct Pixel
    {
        public Pixel(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public uint Width { get; set; }

        public uint Height { get; set; }

        public override string ToString()
        {
            return $"{Width}x{Height}";
        }
    }
}