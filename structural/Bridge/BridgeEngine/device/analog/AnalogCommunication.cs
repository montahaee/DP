using System;

namespace BridgeEngine.device.analog;

public abstract class AnalogCommunication : IDevice
{
    private bool _on;
    private uint _volume = 38;
    private double _frequency;

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

    public uint Volume
    {
        get => _volume;
        set => _volume = value > 100 ? 100 : value;
    }

    protected double Frequency
    {
        get => _frequency;
        set
        {
            ValidateFrequency(value);
            _frequency = value;
        }
    }
    
    public abstract uint Chanel { get; set; }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Enabled: {IsEnabled()}, Volume: {Volume}, Chanel: {Chanel}, " +
                          $"Frequency: {Frequency} MHZ.");
    }

    protected abstract void ValidateFrequency(double frequency);
}