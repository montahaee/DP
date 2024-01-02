using BridgeEngine.device;

namespace BridgeEngine.gui;

public class DeviceForm : Form
{
    private PictureBox _picture;
    private Label _label;
    private IDevice _device;

    public DeviceForm(IDevice device)
    {
        _device = device;
    }
}