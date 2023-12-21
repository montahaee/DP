using BridgeEngine.device;

namespace BridgeEngine.remote;

public class AdvancedRemote : BasicRemote
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        Device.Volume = 0;
    }

    public void Reset()
    {
        Device.Disabled();
        Device.Volume = 0;
        Device.Chanel = 0;
    }
}