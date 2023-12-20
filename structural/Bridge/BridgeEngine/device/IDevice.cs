namespace BridgeEngine.device;

public interface IDevice
{
    bool IsEnabled();

    void Enable();

    void Disabled();

    int Volume { get; set; }

    uint Chanel { get; set; }
    
    void DisplayStatus();
}