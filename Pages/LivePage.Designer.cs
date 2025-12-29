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
            mainLayout = new TableLayoutPanel();
            headerLayout = new TableLayoutPanel();
            txtFilterSensorId = new TextBox();
            btnClearFilter = new Button();
            btnReconnect = new Button();
            lblSpacer = new Label();
            lblStatusCaption = new Label();
            lblStatus = new Label();
            lblFilterCaption = new Label();
            bodyPanel = new Panel();
            flowCards = new FlowLayoutPanel();
            lblEmptyHint = new Label();
            mainLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(bodyPanel, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1000, 600);
            mainLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.BackColor = Color.FromArgb(17, 24, 39);
            headerLayout.ColumnCount = 7;
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.ColumnStyles.Add(new ColumnStyle());
            headerLayout.Controls.Add(txtFilterSensorId, 1, 0);
            headerLayout.Controls.Add(btnClearFilter, 2, 0);
            headerLayout.Controls.Add(btnReconnect, 3, 0);
            headerLayout.Controls.Add(lblSpacer, 4, 0);
            headerLayout.Controls.Add(lblStatusCaption, 5, 0);
            headerLayout.Controls.Add(lblStatus, 6, 0);
            headerLayout.Controls.Add(lblFilterCaption, 0, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(3, 3);
            headerLayout.Name = "headerLayout";
            headerLayout.Padding = new Padding(14, 12, 14, 10);
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            headerLayout.Size = new Size(994, 100);
            headerLayout.TabIndex = 0;
            // 
            // txtFilterSensorId
            // 
            txtFilterSensorId.BackColor = Color.FromArgb(31, 41, 59);
            txtFilterSensorId.BorderStyle = BorderStyle.FixedSingle;
            txtFilterSensorId.Dock = DockStyle.Fill;
            txtFilterSensorId.ForeColor = Color.FromArgb(226, 232, 240);
            txtFilterSensorId.Location = new Point(65, 15);
            txtFilterSensorId.Name = "txtFilterSensorId";
            txtFilterSensorId.PlaceholderText = "sensorId contains...";
            txtFilterSensorId.Size = new Size(331, 27);
            txtFilterSensorId.TabIndex = 1;
            // 
            // btnClearFilter
            // 
            btnClearFilter.AutoSize = true;
            btnClearFilter.BackColor = Color.FromArgb(51, 65, 85);
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.ForeColor = Color.FromArgb(226, 232, 240);
            btnClearFilter.Location = new Point(402, 15);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Padding = new Padding(10, 4, 10, 4);
            btnClearFilter.Size = new Size(75, 38);
            btnClearFilter.TabIndex = 2;
            btnClearFilter.Text = "Clear";
            btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // btnReconnect
            // 
            btnReconnect.AutoSize = true;
            btnReconnect.BackColor = Color.FromArgb(59, 130, 246);
            btnReconnect.FlatAppearance.BorderSize = 0;
            btnReconnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnReconnect.FlatStyle = FlatStyle.Flat;
            btnReconnect.ForeColor = Color.White;
            btnReconnect.Location = new Point(483, 15);
            btnReconnect.Name = "btnReconnect";
            btnReconnect.Padding = new Padding(10, 4, 10, 4);
            btnReconnect.Size = new Size(108, 38);
            btnReconnect.TabIndex = 3;
            btnReconnect.Text = "Reconnect";
            btnReconnect.UseVisualStyleBackColor = false;
            // 
            // lblSpacer
            // 
            lblSpacer.AutoSize = true;
            lblSpacer.Location = new Point(597, 12);
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(0, 20);
            lblSpacer.TabIndex = 4;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Anchor = AnchorStyles.Left;
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblStatusCaption.Location = new Point(821, 41);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(52, 20);
            lblStatusCaption.TabIndex = 5;
            lblStatusCaption.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.FromArgb(191, 219, 254);
            lblStatus.Location = new Point(879, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "disconnected";
            // 
            // lblFilterCaption
            // 
            lblFilterCaption.Anchor = AnchorStyles.Left;
            lblFilterCaption.AutoSize = true;
            lblFilterCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblFilterCaption.Location = new Point(17, 41);
            lblFilterCaption.Name = "lblFilterCaption";
            lblFilterCaption.Size = new Size(42, 20);
            lblFilterCaption.TabIndex = 0;
            lblFilterCaption.Text = "Filter";
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(30, 41, 59);
            bodyPanel.Controls.Add(flowCards);
            bodyPanel.Controls.Add(lblEmptyHint);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(3, 109);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(12);
            bodyPanel.Size = new Size(994, 488);
            bodyPanel.TabIndex = 1;
            // 
            // flowCards
            // 
            flowCards.AutoScroll = true;
            flowCards.BackColor = Color.FromArgb(30, 41, 59);
            flowCards.Dock = DockStyle.Fill;
            flowCards.Location = new Point(12, 12);
            flowCards.Name = "flowCards";
            flowCards.Size = new Size(970, 464);
            flowCards.TabIndex = 0;
            // 
            // lblEmptyHint
            // 
            lblEmptyHint.Dock = DockStyle.Fill;
            lblEmptyHint.Font = new Font("Segoe UI", 11F);
            lblEmptyHint.ForeColor = Color.FromArgb(148, 163, 184);
            lblEmptyHint.Location = new Point(12, 12);
            lblEmptyHint.Name = "lblEmptyHint";
            lblEmptyHint.Size = new Size(970, 464);
            lblEmptyHint.TabIndex = 1;
            lblEmptyHint.Text = "Waiting for live measurements...";
            lblEmptyHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LivePage
            // 
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(mainLayout);
            Name = "LivePage";
            Size = new Size(1000, 600);
            mainLayout.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            headerLayout.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
