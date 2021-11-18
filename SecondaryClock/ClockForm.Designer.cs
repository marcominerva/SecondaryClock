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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ClockContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(-1, -2);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(90, 22);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(0, 21);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(90, 23);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClockContextMenu.Size = new System.Drawing.Size(186, 54);
            // 
            // TaskManagerMenuItem
            // 
            this.TaskManagerMenuItem.Name = "TaskManagerMenuItem";
            this.TaskManagerMenuItem.Size = new System.Drawing.Size(185, 22);
            this.TaskManagerMenuItem.Text = "Gestione attività";
            this.TaskManagerMenuItem.Click += new System.EventHandler(this.TaskManagerMenuItem_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 45);
            this.ContextMenuStrip = this.ClockContextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
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
}
