using System.Diagnostics;
using SecondaryClock.Taskbar;

namespace SecondaryClock;

public partial class ClockForm : Form
{
    public ClockForm()
    {
        InitializeComponent();
        UpdateClock();

        ForeColor = TaskbarHelper.UsesLightTheme() ? Color.Black : Color.White;
        BackColor = TaskbarHelper.GetColor();
        TransparencyKey = BackColor;
        Size = new Size(90, 45);

        var screen = Screen.AllScreens.LastOrDefault()?.Bounds ?? Screen.PrimaryScreen.Bounds;
        Top = screen.Height - Height - 1;
        Left = screen.X + screen.Width - Width + 1;
    }

    private void ClockTimer_Tick(object sender, EventArgs e) => UpdateClock();

    private void UpdateClock()
    {
        BringToFront();

        var now = DateTime.Now;
        TimeLabel.Text = now.ToShortTimeString();
        DateLabel.Text = now.ToShortDateString();

        DateTooltip.SetToolTip(TimeLabel, now.ToLongTimeString());
        DateTooltip.SetToolTip(DateLabel, now.ToLongDateString());
    }

    private void TaskManagerMenuItem_Click(object sender, EventArgs e)
        => Process.Start(new ProcessStartInfo { FileName = "taskmgr.exe", Verb = "runas", UseShellExecute = true });
}
