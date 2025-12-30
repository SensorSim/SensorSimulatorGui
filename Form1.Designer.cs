namespace SensorSimulatorGui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnNavSensors;
        private System.Windows.Forms.Button btnNavLive;
        private System.Windows.Forms.Button btnNavArchived;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblEndpoints;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelNav = new Panel();
            btnNavArchived = new Button();
            btnNavLive = new Button();
            btnNavSensors = new Button();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            lblEndpoints = new ToolStripStatusLabel();
            panelNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(17, 24, 39);
            panelNav.Controls.Add(btnNavArchived);
            panelNav.Controls.Add(btnNavLive);
            panelNav.Controls.Add(btnNavSensors);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Padding = new Padding(10, 14, 10, 10);
            panelNav.Size = new Size(160, 688);
            panelNav.TabIndex = 1;
            // 
            // btnNavArchived
            // 
            btnNavArchived.Dock = DockStyle.Top;
            btnNavArchived.FlatAppearance.BorderSize = 0;
            btnNavArchived.FlatAppearance.MouseDownBackColor = Color.FromArgb(91, 33, 182);
            btnNavArchived.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnNavArchived.FlatStyle = FlatStyle.Flat;
            btnNavArchived.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavArchived.Location = new Point(10, 102);
            btnNavArchived.Margin = new Padding(0, 0, 0, 6);
            btnNavArchived.Name = "btnNavArchived";
            btnNavArchived.Padding = new Padding(12, 0, 0, 0);
            btnNavArchived.Size = new Size(140, 44);
            btnNavArchived.TabIndex = 0;
            btnNavArchived.Text = "Archived";
            btnNavArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavLive
            // 
            btnNavLive.Dock = DockStyle.Top;
            btnNavLive.FlatAppearance.BorderSize = 0;
            btnNavLive.FlatAppearance.MouseDownBackColor = Color.FromArgb(91, 33, 182);
            btnNavLive.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnNavLive.FlatStyle = FlatStyle.Flat;
            btnNavLive.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavLive.Location = new Point(10, 58);
            btnNavLive.Margin = new Padding(0, 0, 0, 6);
            btnNavLive.Name = "btnNavLive";
            btnNavLive.Padding = new Padding(12, 0, 0, 0);
            btnNavLive.Size = new Size(140, 44);
            btnNavLive.TabIndex = 1;
            btnNavLive.Text = "Live data";
            btnNavLive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavSensors
            // 
            btnNavSensors.Dock = DockStyle.Top;
            btnNavSensors.FlatAppearance.BorderSize = 0;
            btnNavSensors.FlatAppearance.MouseDownBackColor = Color.FromArgb(91, 33, 182);
            btnNavSensors.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnNavSensors.FlatStyle = FlatStyle.Flat;
            btnNavSensors.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavSensors.Location = new Point(10, 14);
            btnNavSensors.Margin = new Padding(0, 0, 0, 6);
            btnNavSensors.Name = "btnNavSensors";
            btnNavSensors.Padding = new Padding(12, 0, 0, 0);
            btnNavSensors.Size = new Size(140, 44);
            btnNavSensors.TabIndex = 2;
            btnNavSensors.Text = "Sensors";
            btnNavSensors.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(30, 41, 59);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(160, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(14, 14, 14, 10);
            panelContent.Size = new Size(1231, 688);
            panelContent.TabIndex = 0;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(17, 24, 39);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblEndpoints });
            statusStrip.Location = new Point(0, 688);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1391, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 2;
            // 
            // lblEndpoints
            // 
            lblEndpoints.ForeColor = Color.FromArgb(226, 232, 240);
            lblEndpoints.Name = "lblEndpoints";
            lblEndpoints.Size = new Size(1376, 20);
            lblEndpoints.Spring = true;
            lblEndpoints.Text = "Endpoints: (loaded from appsettings.json)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1391, 714);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(820, 520);
            Name = "Form1";
            Text = "Reactor Monitor – GUI";
            panelNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
