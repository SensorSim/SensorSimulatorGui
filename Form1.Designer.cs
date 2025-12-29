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

            // panelNav
            // Left-side navigation. Keep it narrow by default so the pages have room.
            panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            panelNav.Width = 140;
            panelNav.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);

            btnNavSensors.Text = "Sensors";
            btnNavSensors.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavSensors.Height = 32;
            btnNavSensors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            btnNavLive.Text = "Live data";
            btnNavLive.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavLive.Height = 32;
            btnNavLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            btnNavArchived.Text = "Archived data";
            btnNavArchived.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavArchived.Height = 32;
            btnNavArchived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            panelNav.Controls.Add(btnNavArchived);
            panelNav.Controls.Add(btnNavLive);
            panelNav.Controls.Add(btnNavSensors);

            // panelContent
            panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContent.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            // statusStrip
            statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                lblEndpoints
            });

            lblEndpoints.Text = "Endpoints: (loaded from appsettings.json)";
            lblEndpoints.Spring = true;

            // Form1
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // More compact default size (still fully resizable).
            ClientSize = new System.Drawing.Size(880, 540);
            // Dock order matters: add Fill first, then Left, then Bottom.
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(statusStrip);
            MinimumSize = new System.Drawing.Size(780, 500);
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
