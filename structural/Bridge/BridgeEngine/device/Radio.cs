using System;

namespace BridgeEngine.device;

public class Radio : IDevice
{
    private bool _on = false;
    private int _volume = 38;
    private double _frequency = 88.0;
    
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
        get => (uint)((_frequency - 88.0) * 10);
        set
        {
            double newFrequency = value / 10.0 + 88.0;
            ValidateFrequency(newFrequency);
            _frequency = newFrequency;
        }
    }

    public double Frequency
    {
        get => _frequency;
        set {
            
            ValidateFrequency(value);
            _frequency = value;
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Enabled: {_on}, Volume: {_volume}, Chanel: {Chanel}, Frequency: {_frequency} MHZ");
    }

    private void ValidateFrequency(double frequency)
    {
        if (frequency < 88.0 || frequency > 108.0)
        {
            throw new ArgumentOutOfRangeException("Chanel must correspond to a frequency " +
                                                  "between 88.0 and 108.0");
        }
    }
}