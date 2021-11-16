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
        var now = DateTime.Now;
        TimeLabel.Text = now.ToShortTimeString();
        DateLabel.Text = now.ToShortDateString();
    }
}
