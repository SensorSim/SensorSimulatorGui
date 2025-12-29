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
            components = new System.ComponentModel.Container();
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            panelFilterHost = new System.Windows.Forms.Panel();
            panelGridHost = new System.Windows.Forms.Panel();
            filterLayout = new System.Windows.Forms.TableLayoutPanel();

            lblSensorCaption = new System.Windows.Forms.Label();
            txtSensorId = new System.Windows.Forms.TextBox();

            lblFromCaption = new System.Windows.Forms.Label();
            dtFrom = new System.Windows.Forms.DateTimePicker();

            lblToCaption = new System.Windows.Forms.Label();
            dtTo = new System.Windows.Forms.DateTimePicker();

            lblPageCaption = new System.Windows.Forms.Label();
            numPage = new System.Windows.Forms.NumericUpDown();

            btnLoad = new System.Windows.Forms.Button();

            lblStatus = new System.Windows.Forms.Label();
            dgvArchived = new System.Windows.Forms.DataGridView();

            mainLayout.SuspendLayout();
            filterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchived).BeginInit();
            SuspendLayout();

            // ArchivedPage
            BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // mainLayout
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.Padding = new System.Windows.Forms.Padding(12);
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Controls.Add(panelFilterHost, 0, 0);
            mainLayout.Controls.Add(lblStatus, 0, 1);
            mainLayout.Controls.Add(panelGridHost, 0, 2);

            // panelFilterHost
            panelFilterHost.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFilterHost.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelFilterHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelFilterHost.Controls.Add(filterLayout);

            // filterLayout
            filterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            filterLayout.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            filterLayout.Padding = new System.Windows.Forms.Padding(14, 12, 14, 10);
            filterLayout.ColumnCount = 9;
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));

            // SensorId
            lblSensorCaption.AutoSize = true;
            lblSensorCaption.Text = "SensorId";
            lblSensorCaption.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblSensorCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSensorId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSensorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // From
            lblFromCaption.AutoSize = true;
            lblFromCaption.Text = "From";
            lblFromCaption.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblFromCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtFrom.ShowCheckBox = true;
            dtFrom.Dock = System.Windows.Forms.DockStyle.Fill;

            // To
            lblToCaption.AutoSize = true;
            lblToCaption.Text = "To";
            lblToCaption.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblToCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtTo.ShowCheckBox = true;
            dtTo.Dock = System.Windows.Forms.DockStyle.Fill;

            // Page
            lblPageCaption.AutoSize = true;
            lblPageCaption.Text = "Page";
            lblPageCaption.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblPageCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numPage.Minimum = 1;
            numPage.Maximum = 100000;
            numPage.Value = 1;
            numPage.Dock = System.Windows.Forms.DockStyle.Fill;

            // Load button
            btnLoad.Text = "Load";
            btnLoad.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            btnLoad.ForeColor = System.Drawing.Color.White;
            btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            btnLoad.AutoSize = true;
            btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoad.FlatAppearance.BorderSize = 0;

            // status
            lblStatus.AutoSize = true;
            lblStatus.Text = "Ready.";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 6);

            // add filter controls
            filterLayout.Controls.Add(lblSensorCaption, 0, 0);
            filterLayout.Controls.Add(txtSensorId, 1, 0);

            filterLayout.Controls.Add(lblFromCaption, 2, 0);
            filterLayout.Controls.Add(dtFrom, 3, 0);

            filterLayout.Controls.Add(lblToCaption, 4, 0);
            filterLayout.Controls.Add(dtTo, 5, 0);

            filterLayout.Controls.Add(lblPageCaption, 6, 0);
            filterLayout.Controls.Add(numPage, 7, 0);

            filterLayout.Controls.Add(btnLoad, 8, 0);

            // panelGridHost
            panelGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGridHost.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelGridHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelGridHost.Padding = new System.Windows.Forms.Padding(6);
            panelGridHost.Controls.Add(dgvArchived);

            // dgvArchived
            dgvArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchived.AllowUserToAddRows = false;
            dgvArchived.AllowUserToDeleteRows = false;
            dgvArchived.ReadOnly = true;
            dgvArchived.MultiSelect = false;
            dgvArchived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvArchived.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvArchived.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgvArchived.RowHeadersVisible = false;
            dgvArchived.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvArchived.EnableHeadersVisualStyles = false;
            dgvArchived.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvArchived.ColumnHeadersHeight = 34;
            dgvArchived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvArchived.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138); // dark blue
            dgvArchived.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvArchived.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            dgvArchived.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvArchived.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254); // light blue
            dgvArchived.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvArchived.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvArchived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArchived.RowTemplate.Height = 30;
            dgvArchived.Name = "dgvArchived";
            dgvArchived.TabIndex = 0;

            // ArchivedPage
            Controls.Add(mainLayout);
            Name = "ArchivedPage";
            Size = new System.Drawing.Size(1000, 600);

            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchived).EndInit();
            ResumeLayout(false);
        }
    }
}
