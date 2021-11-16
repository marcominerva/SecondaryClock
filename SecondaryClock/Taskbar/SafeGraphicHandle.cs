using Microsoft.Win32.SafeHandles;

namespace SecondaryClock.Taskbar;

public class SaveGraphicHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    public SaveGraphicHandle(IntPtr handle)
           : base(true)
    {
        SetHandle(handle);
    }

    public SaveGraphicHandle()
           : base(true)
    {
        SetHandle(handle);
    }

    protected override bool ReleaseHandle() => true;
}
