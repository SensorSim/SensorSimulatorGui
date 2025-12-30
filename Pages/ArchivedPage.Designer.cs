namespace SensorSimulatorGui.Pages
{
    partial class ArchivedPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel filterLayout;
        private System.Windows.Forms.Panel panelFilterHost;
        private System.Windows.Forms.Panel panelGridHost;

        private System.Windows.Forms.Label lblSensorCaption;
        private System.Windows.Forms.TextBox txtSensorId;

        private System.Windows.Forms.Label lblFromCaption;
        private System.Windows.Forms.DateTimePicker dtFrom;

        private System.Windows.Forms.Label lblToCaption;
        private System.Windows.Forms.DateTimePicker dtTo;

        private System.Windows.Forms.Label lblPageCaption;
        private System.Windows.Forms.NumericUpDown numPage;

        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvArchived;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            mainLayout = new TableLayoutPanel();
            panelFilterHost = new Panel();
            filterLayout = new TableLayoutPanel();
            lblSensorCaption = new Label();
            txtSensorId = new TextBox();
            lblFromCaption = new Label();
            dtFrom = new DateTimePicker();
            lblToCaption = new Label();
            dtTo = new DateTimePicker();
            lblPageCaption = new Label();
            numPage = new NumericUpDown();
            btnLoad = new Button();
            lblStatus = new Label();
            panelGridHost = new Panel();
            dgvArchived = new DataGridView();
            mainLayout.SuspendLayout();
            panelFilterHost.SuspendLayout();
            filterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPage).BeginInit();
            panelGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArchived).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayout.Controls.Add(panelFilterHost, 0, 0);
            mainLayout.Controls.Add(lblStatus, 0, 1);
            mainLayout.Controls.Add(panelGridHost, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(12);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1000, 600);
            mainLayout.TabIndex = 0;
            // 
            // panelFilterHost
            // 
            panelFilterHost.BackColor = Color.FromArgb(37, 51, 71);
            panelFilterHost.BorderStyle = BorderStyle.FixedSingle;
            panelFilterHost.Controls.Add(filterLayout);
            panelFilterHost.Dock = DockStyle.Fill;
            panelFilterHost.Location = new Point(15, 15);
            panelFilterHost.Name = "panelFilterHost";
            panelFilterHost.Size = new Size(970, 100);
            panelFilterHost.TabIndex = 0;
            // 
            // filterLayout
            // 
            filterLayout.BackColor = Color.FromArgb(37, 51, 71);
            filterLayout.ColumnCount = 9;
            filterLayout.ColumnStyles.Add(new ColumnStyle());
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            filterLayout.ColumnStyles.Add(new ColumnStyle());
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            filterLayout.ColumnStyles.Add(new ColumnStyle());
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            filterLayout.ColumnStyles.Add(new ColumnStyle());
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new ColumnStyle());
            filterLayout.Controls.Add(lblSensorCaption, 0, 0);
            filterLayout.Controls.Add(txtSensorId, 1, 0);
            filterLayout.Controls.Add(lblFromCaption, 2, 0);
            filterLayout.Controls.Add(dtFrom, 3, 0);
            filterLayout.Controls.Add(lblToCaption, 4, 0);
            filterLayout.Controls.Add(dtTo, 5, 0);
            filterLayout.Controls.Add(lblPageCaption, 6, 0);
            filterLayout.Controls.Add(numPage, 7, 0);
            filterLayout.Controls.Add(btnLoad, 8, 0);
            filterLayout.Dock = DockStyle.Fill;
            filterLayout.Location = new Point(0, 0);
            filterLayout.Name = "filterLayout";
            filterLayout.Padding = new Padding(14, 12, 14, 10);
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            filterLayout.Size = new Size(968, 98);
            filterLayout.TabIndex = 0;
            // 
            // lblSensorCaption
            // 
            lblSensorCaption.Anchor = AnchorStyles.Left;
            lblSensorCaption.AutoSize = true;
            lblSensorCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblSensorCaption.Location = new Point(17, 40);
            lblSensorCaption.Name = "lblSensorCaption";
            lblSensorCaption.Size = new Size(66, 20);
            lblSensorCaption.TabIndex = 0;
            lblSensorCaption.Text = "SensorId";
            // 
            // txtSensorId
            // 
            txtSensorId.BackColor = Color.FromArgb(51, 65, 85);
            txtSensorId.BorderStyle = BorderStyle.FixedSingle;
            txtSensorId.Dock = DockStyle.Fill;
            txtSensorId.ForeColor = Color.FromArgb(226, 232, 240);
            txtSensorId.Location = new Point(89, 15);
            txtSensorId.Name = "txtSensorId";
            txtSensorId.Size = new Size(265, 27);
            txtSensorId.TabIndex = 1;
            // 
            // lblFromCaption
            // 
            lblFromCaption.Anchor = AnchorStyles.Left;
            lblFromCaption.AutoSize = true;
            lblFromCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblFromCaption.Location = new Point(360, 40);
            lblFromCaption.Name = "lblFromCaption";
            lblFromCaption.Size = new Size(43, 20);
            lblFromCaption.TabIndex = 2;
            lblFromCaption.Text = "From";
            // 
            // dtFrom
            // 
            dtFrom.BackColor = Color.FromArgb(51, 65, 85);
            dtFrom.CalendarMonthBackground = Color.FromArgb(51, 65, 85);
            dtFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtFrom.Dock = DockStyle.Fill;
            dtFrom.ForeColor = Color.FromArgb(226, 232, 240);
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(409, 15);
            dtFrom.Name = "dtFrom";
            dtFrom.ShowCheckBox = true;
            dtFrom.Size = new Size(149, 27);
            dtFrom.TabIndex = 3;
            // 
            // lblToCaption
            // 
            lblToCaption.Anchor = AnchorStyles.Left;
            lblToCaption.AutoSize = true;
            lblToCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblToCaption.Location = new Point(564, 40);
            lblToCaption.Name = "lblToCaption";
            lblToCaption.Size = new Size(25, 20);
            lblToCaption.TabIndex = 4;
            lblToCaption.Text = "To";
            // 
            // dtTo
            // 
            dtTo.BackColor = Color.FromArgb(51, 65, 85);
            dtTo.CalendarMonthBackground = Color.FromArgb(51, 65, 85);
            dtTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtTo.Dock = DockStyle.Fill;
            dtTo.ForeColor = Color.FromArgb(226, 232, 240);
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(595, 15);
            dtTo.Name = "dtTo";
            dtTo.ShowCheckBox = true;
            dtTo.Size = new Size(149, 27);
            dtTo.TabIndex = 5;
            // 
            // lblPageCaption
            // 
            lblPageCaption.Anchor = AnchorStyles.Left;
            lblPageCaption.AutoSize = true;
            lblPageCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblPageCaption.Location = new Point(750, 40);
            lblPageCaption.Name = "lblPageCaption";
            lblPageCaption.Size = new Size(41, 20);
            lblPageCaption.TabIndex = 6;
            lblPageCaption.Text = "Page";
            // 
            // numPage
            // 
            numPage.BackColor = Color.FromArgb(51, 65, 85);
            numPage.Dock = DockStyle.Fill;
            numPage.ForeColor = Color.FromArgb(226, 232, 240);
            numPage.Location = new Point(797, 15);
            numPage.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPage.Name = "numPage";
            numPage.Size = new Size(71, 27);
            numPage.TabIndex = 7;
            numPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnLoad
            // 
            btnLoad.AutoSize = true;
            btnLoad.BackColor = Color.FromArgb(59, 130, 246);
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(874, 15);
            btnLoad.Name = "btnLoad";
            btnLoad.Padding = new Padding(10, 4, 10, 4);
            btnLoad.Size = new Size(75, 38);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.FromArgb(226, 232, 240);
            lblStatus.Location = new Point(15, 118);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(10, 0, 10, 6);
            lblStatus.Size = new Size(73, 26);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Ready.";
            // 
            // panelGridHost
            // 
            panelGridHost.BackColor = Color.FromArgb(37, 51, 71);
            panelGridHost.BorderStyle = BorderStyle.FixedSingle;
            panelGridHost.Controls.Add(dgvArchived);
            panelGridHost.Dock = DockStyle.Fill;
            panelGridHost.Location = new Point(15, 147);
            panelGridHost.Name = "panelGridHost";
            panelGridHost.Padding = new Padding(6);
            panelGridHost.Size = new Size(970, 438);
            panelGridHost.TabIndex = 2;
            // 
            // dgvArchived
            // 
            dgvArchived.AllowUserToAddRows = false;
            dgvArchived.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 59, 79);
            dgvArchived.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvArchived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArchived.BackgroundColor = Color.FromArgb(37, 51, 71);
            dgvArchived.BorderStyle = BorderStyle.None;
            dgvArchived.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArchived.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvArchived.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvArchived.ColumnHeadersHeight = 34;
            dgvArchived.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 51, 71);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(196, 181, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvArchived.DefaultCellStyle = dataGridViewCellStyle3;
            dgvArchived.Dock = DockStyle.Fill;
            dgvArchived.EnableHeadersVisualStyles = false;
            dgvArchived.GridColor = Color.FromArgb(71, 85, 105);
            dgvArchived.Location = new Point(6, 6);
            dgvArchived.MultiSelect = false;
            dgvArchived.Name = "dgvArchived";
            dgvArchived.ReadOnly = true;
            dgvArchived.RowHeadersVisible = false;
            dgvArchived.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 51, 71);
            dgvArchived.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvArchived.RowTemplate.Height = 30;
            dgvArchived.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArchived.Size = new Size(956, 424);
            dgvArchived.TabIndex = 0;
            // 
            // ArchivedPage
            // 
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(mainLayout);
            Name = "ArchivedPage";
            Size = new Size(1000, 600);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            panelFilterHost.ResumeLayout(false);
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPage).EndInit();
            panelGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArchived).EndInit();
            ResumeLayout(false);
        }
    }
}