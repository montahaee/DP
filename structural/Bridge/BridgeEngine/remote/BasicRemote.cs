using System;
using BridgeEngine.device;

namespace BridgeEngine.remote;

public class BasicRemote : IRemote
{
    protected readonly IDevice Device;

    protected BasicRemote(IDevice device)
    {
        Device = device ?? throw new ArgumentNullException(nameof(device));
    }
    //TODO using graphical options from device package for the following methods.
    public void Power()
    {
        if (Device.IsEnabled())
        { 
            Device.Disabled();
        } else {
            Device.Enable();
        }
    }

    public void VolumeDown()
    {
        Device.Volume -= 10;
    }

    public void VolumeUp()
    {
        Device.Volume += 10;
    }

    public void ChannelDown()
    {
        Device.Chanel -= 1;
    }

    public void ChannelUp()
    {
        Device.Chanel += 1;
    }
}