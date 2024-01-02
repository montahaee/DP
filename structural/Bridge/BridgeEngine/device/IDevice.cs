namespace BridgeEngine.device;

public interface IDevice
{
    uint Volume { get; set; }

    uint Chanel { get; set; }
    bool IsEnabled();

    void Enable();

    void Disabled();

    // TODO change the display methode to Tostring methode.
    void DisplayStatus();
}