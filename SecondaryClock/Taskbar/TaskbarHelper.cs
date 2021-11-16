using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Graphics.Gdi;

namespace SecondaryClock.Taskbar;

public static class TaskbarHelper
{
    public static bool UsesLightTheme()
    {
        try
        {
            var usesLightTheme = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", "1");
            if (usesLightTheme?.ToString() == "0")
            {
                return false;
            }
        }
        catch
        {
        }

        return true;
    }

    public static Color GetColor() => GetColorAt(GetPosition().Location);

    public static Rectangle GetPosition()
    {
        var data = new Windows.Win32.UI.Shell.APPBARDATA();
        data.cbSize = (uint)Marshal.SizeOf(data);

        PInvoke.SHAppBarMessage(PInvoke.ABM_GETTASKBARPOS, ref data);
        return new Rectangle(data.rc.left, data.rc.top, data.rc.right - data.rc.left, data.rc.bottom - data.rc.top);
    }

    private static Color GetColorAt(Point location)
    {
        using var screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        using var gDestination = Graphics.FromImage(screenPixel);
        using var gSource = Graphics.FromHwnd(IntPtr.Zero);

        var hSrcDC = gSource.GetHdc();
        using var safeHandleSrcDC = new SaveGraphicHandle(hSrcDC);

        var hDC = gDestination.GetHdc();
        using var safeHandleDC = new SaveGraphicHandle(hDC);

        PInvoke.BitBlt(safeHandleDC, 0, 0, 1, 1, safeHandleSrcDC, location.X, location.Y, ROP_CODE.SRCCOPY);

        gDestination.ReleaseHdc();
        gSource.ReleaseHdc();

        return screenPixel.GetPixel(0, 0);
    }
}
