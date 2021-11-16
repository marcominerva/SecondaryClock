using SecondaryClock.Taskbar;

namespace SecondaryClock;

public partial class frmClock : Form
{
    public frmClock()
    {
        InitializeComponent();

        ForeColor = TaskbarHelper.UsesLightTheme() ? Color.Black : Color.White;
        BackColor = TaskbarHelper.GetColor();
        TransparencyKey = BackColor;

        UpdateClock();

        var screen = Screen.AllScreens.Last();
        Top = screen.Bounds.Height - Height;
        Left = screen.Bounds.X + screen.Bounds.Width - Width + 1;
    }

    private void ClockTimer_Tick(object sender, EventArgs e) => UpdateClock();

    private void UpdateClock()
    {
        var now = DateTime.Now;
        TimeLabel.Text = now.ToShortTimeString();
        DateLabel.Text = now.ToShortDateString();
    }
}
