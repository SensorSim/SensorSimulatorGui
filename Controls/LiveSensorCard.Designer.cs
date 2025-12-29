namespace SensorSimulatorGui.Controls
{
    partial class LiveSensorCard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.TableLayoutPanel layout;

        private System.Windows.Forms.Label lblSensorId;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblTimestamp;

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
            panelCard = new System.Windows.Forms.Panel();
            layout = new System.Windows.Forms.TableLayoutPanel();

            lblSensorId = new System.Windows.Forms.Label();
            pnlIndicator = new System.Windows.Forms.Panel();
            lblValue = new System.Windows.Forms.Label();
            lblUnit = new System.Windows.Forms.Label();
            lblTimestamp = new System.Windows.Forms.Label();

            panelCard.SuspendLayout();
            layout.SuspendLayout();
            SuspendLayout();

            // panelCard
            panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCard.Padding = new System.Windows.Forms.Padding(12);
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // layout
            layout.Dock = System.Windows.Forms.DockStyle.Fill;
            layout.ColumnCount = 2;
            layout.RowCount = 3;
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // lblSensorId
            lblSensorId.AutoSize = true;
            lblSensorId.Text = "sensor-id";
            lblSensorId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSensorId.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSensorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlIndicator
            pnlIndicator.Width = 10;
            pnlIndicator.Height = 10;
            pnlIndicator.Margin = new System.Windows.Forms.Padding(6, 6, 0, 0);
            pnlIndicator.BackColor = System.Drawing.Color.FromArgb(60, 179, 113); // green-ish
            pnlIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // lblValue
            lblValue.AutoSize = true;
            lblValue.Text = "—";
            lblValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblUnit
            lblUnit.AutoSize = true;
            lblUnit.Text = "";
            lblUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblUnit.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblUnit.Margin = new System.Windows.Forms.Padding(8, 18, 0, 0);

            // lblTimestamp
            lblTimestamp.AutoSize = true;
            lblTimestamp.Text = "";
            lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            lblTimestamp.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            lblTimestamp.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTimestamp.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            layout.Controls.Add(lblSensorId, 0, 0);
            layout.Controls.Add(pnlIndicator, 1, 0);
            layout.Controls.Add(lblValue, 0, 1);
            layout.Controls.Add(lblUnit, 1, 1);
            layout.Controls.Add(lblTimestamp, 0, 2);
            layout.SetColumnSpan(lblTimestamp, 2);

            panelCard.Controls.Add(layout);

            // LiveSensorCard
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(panelCard);
            Name = "LiveSensorCard";
            Size = new System.Drawing.Size(240, 120);

            panelCard.ResumeLayout(false);
            layout.ResumeLayout(false);
            layout.PerformLayout();
            ResumeLayout(false);
        }
    }
}
