namespace SensorSimulatorGui.Pages
{
    partial class LivePage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel headerLayout;

        private System.Windows.Forms.Label lblFilterCaption;
        private System.Windows.Forms.TextBox txtFilterSensorId;
        private System.Windows.Forms.Button btnClearFilter;

        private System.Windows.Forms.Button btnReconnect;

        private System.Windows.Forms.Label lblSpacer;

        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private System.Windows.Forms.Label lblEmptyHint;

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
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            headerLayout = new System.Windows.Forms.TableLayoutPanel();

            lblFilterCaption = new System.Windows.Forms.Label();
            txtFilterSensorId = new System.Windows.Forms.TextBox();
            btnClearFilter = new System.Windows.Forms.Button();

            btnReconnect = new System.Windows.Forms.Button();

            lblSpacer = new System.Windows.Forms.Label();

            lblStatusCaption = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();

            bodyPanel = new System.Windows.Forms.Panel();
            flowCards = new System.Windows.Forms.FlowLayoutPanel();
            lblEmptyHint = new System.Windows.Forms.Label();

            mainLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();

            // LivePage
            BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // mainLayout
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(bodyPanel, 0, 1);

            // headerLayout
            headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            headerLayout.BackColor = System.Drawing.Color.FromArgb(17, 24, 39); // dark header
            headerLayout.Padding = new System.Windows.Forms.Padding(14, 12, 14, 10);
            headerLayout.ColumnCount = 7;
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));

            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Text = "Filter";
            lblFilterCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblFilterCaption.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);

            txtFilterSensorId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtFilterSensorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFilterSensorId.PlaceholderText = "sensorId contains...";

            txtFilterSensorId.BackColor = System.Drawing.Color.FromArgb(31, 41, 59);
            txtFilterSensorId.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);

            btnClearFilter.Text = "Clear";
            btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnClearFilter.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            btnClearFilter.AutoSize = true;

            btnReconnect.Text = "Reconnect";
            btnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReconnect.FlatAppearance.BorderSize = 0;
            btnReconnect.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            btnReconnect.ForeColor = System.Drawing.Color.White;
            btnReconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnReconnect.UseVisualStyleBackColor = false;
            btnReconnect.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            btnReconnect.AutoSize = true;

            lblSpacer.AutoSize = true;
            lblSpacer.Text = "";

            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Text = "Status:";
            lblStatusCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);

            lblStatus.AutoSize = true;
            lblStatus.Text = "disconnected";
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254);

            headerLayout.Controls.Add(lblFilterCaption, 0, 0);
            headerLayout.Controls.Add(txtFilterSensorId, 1, 0);
            headerLayout.Controls.Add(btnClearFilter, 2, 0);
            headerLayout.Controls.Add(btnReconnect, 3, 0);
            headerLayout.Controls.Add(lblSpacer, 4, 0);
            headerLayout.Controls.Add(lblStatusCaption, 5, 0);
            headerLayout.Controls.Add(lblStatus, 6, 0);

            // bodyPanel
            bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            bodyPanel.Padding = new System.Windows.Forms.Padding(12);
            bodyPanel.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // flowCards
            flowCards.Dock = System.Windows.Forms.DockStyle.Fill;
            flowCards.AutoScroll = true;
            flowCards.WrapContents = true;
            flowCards.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowCards.Padding = new System.Windows.Forms.Padding(0);
            flowCards.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // lblEmptyHint
            lblEmptyHint.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEmptyHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblEmptyHint.Text = "Waiting for live measurements...";
            lblEmptyHint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            lblEmptyHint.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);

            bodyPanel.Controls.Add(flowCards);
            bodyPanel.Controls.Add(lblEmptyHint);

            // LivePage
            Controls.Add(mainLayout);
            Name = "LivePage";
            Size = new System.Drawing.Size(1000, 600);

            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headerLayout.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
