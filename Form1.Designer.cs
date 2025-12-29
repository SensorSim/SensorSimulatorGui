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
            components = new System.ComponentModel.Container();
            panelNav = new System.Windows.Forms.Panel();
            btnNavSensors = new System.Windows.Forms.Button();
            btnNavLive = new System.Windows.Forms.Button();
            btnNavArchived = new System.Windows.Forms.Button();

            panelContent = new System.Windows.Forms.Panel();

            statusStrip = new System.Windows.Forms.StatusStrip();
            lblEndpoints = new System.Windows.Forms.ToolStripStatusLabel();

            panelNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();

            // Form look
            BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            Font = new System.Drawing.Font("Segoe UI", 10F);

            // panelNav
            panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            panelNav.Width = 160;
            panelNav.Padding = new System.Windows.Forms.Padding(10, 14, 10, 10);
            panelNav.BackColor = System.Drawing.Color.FromArgb(17, 24, 39); // dark blue

            // btnNavSensors
            btnNavSensors.Text = "Sensors";
            btnNavSensors.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavSensors.Height = 44;
            btnNavSensors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavSensors.FlatAppearance.BorderSize = 0;
            btnNavSensors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnNavSensors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavSensors.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
btnNavSensors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
btnNavSensors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavSensors.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnNavSensors.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavSensors.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);

            // btnNavLive
            btnNavLive.Text = "Live data";
            btnNavLive.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavLive.Height = 44;
            btnNavLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavLive.FlatAppearance.BorderSize = 0;
            btnNavLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnNavLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavLive.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
btnNavLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
btnNavLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavLive.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnNavLive.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavLive.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);

            // btnNavArchived
            btnNavArchived.Text = "Archived";
            btnNavArchived.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavArchived.Height = 44;
            btnNavArchived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavArchived.FlatAppearance.BorderSize = 0;
            btnNavArchived.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnNavArchived.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavArchived.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
btnNavArchived.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
btnNavArchived.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(91, 33, 182);
            btnNavArchived.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnNavArchived.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnNavArchived.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);

            panelNav.Controls.Add(btnNavArchived);
            panelNav.Controls.Add(btnNavLive);
            panelNav.Controls.Add(btnNavSensors);

            // panelContent
            panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContent.Padding = new System.Windows.Forms.Padding(14, 14, 14, 10);
            panelContent.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // statusStrip
            statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            statusStrip.BackColor = System.Drawing.Color.FromArgb(17, 24, 39); // match nav
            statusStrip.SizingGrip = false;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                lblEndpoints
            });

            lblEndpoints.Text = "Endpoints: (loaded from appsettings.json)";
            lblEndpoints.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblEndpoints.Spring = true;

            // Form1
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(920, 560);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(statusStrip);
            MinimumSize = new System.Drawing.Size(820, 520);
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
