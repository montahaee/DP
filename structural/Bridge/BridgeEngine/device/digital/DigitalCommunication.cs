namespace BridgeEngine.device.digital;

/// <summary>
///     Digital feature of the <see cref="IDevice" /> will not be worked!
/// </summary>
public abstract class DigitalCommunication : IDevice
{
    public abstract bool IsEnabled();

    public abstract void Enable();

    public abstract void Disabled();

    public abstract uint Volume { get; set; }

    public abstract uint Chanel { get; set; }

    public abstract void DisplayStatus();
}