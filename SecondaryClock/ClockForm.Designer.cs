namespace SecondaryClock;

partial class ClockForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ClockContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BringToFrontTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            resources.ApplyResources(this.TimeLabel, "TimeLabel");
            this.TimeLabel.Name = "TimeLabel";
            // 
            // DateLabel
            // 
            resources.ApplyResources(this.DateLabel, "DateLabel");
            this.DateLabel.Name = "DateLabel";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 500;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ClockContextMenu
            // 
            this.ClockContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClockContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskManagerMenuItem});
            this.ClockContextMenu.Name = "ClockContextMenu";
            this.ClockContextMenu.ShowImageMargin = false;
            resources.ApplyResources(this.ClockContextMenu, "ClockContextMenu");
            // 
            // TaskManagerMenuItem
            // 
            this.TaskManagerMenuItem.Name = "TaskManagerMenuItem";
            resources.ApplyResources(this.TaskManagerMenuItem, "TaskManagerMenuItem");
            this.TaskManagerMenuItem.Click += new System.EventHandler(this.TaskManagerMenuItem_Click);
            // 
            // BringToFrontTimer
            // 
            this.BringToFrontTimer.Enabled = true;
            this.BringToFrontTimer.Interval = 1;
            this.BringToFrontTimer.Tick += new System.EventHandler(this.BringToFrontTimer_Tick);
            // 
            // ClockForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ClockContextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ClockContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Label TimeLabel;
    private Label DateLabel;
    private System.Windows.Forms.Timer ClockTimer;
    private ToolTip DateTooltip;
    private ContextMenuStrip ClockContextMenu;
    private ToolStripMenuItem TaskManagerMenuItem;
    private System.Windows.Forms.Timer BringToFrontTimer;
}
