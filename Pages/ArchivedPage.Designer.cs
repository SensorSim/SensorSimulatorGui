namespace SensorSimulatorGui.Pages
{
    partial class ArchivedPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel filterLayout;

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

            // mainLayout
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Controls.Add(filterLayout, 0, 0);
            mainLayout.Controls.Add(lblStatus, 0, 1);
            mainLayout.Controls.Add(dgvArchived, 0, 2);

            // filterLayout
            filterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            filterLayout.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
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
            lblSensorCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSensorId.Dock = System.Windows.Forms.DockStyle.Fill;

            // From
            lblFromCaption.AutoSize = true;
            lblFromCaption.Text = "From";
            lblFromCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtFrom.ShowCheckBox = true;
            dtFrom.Dock = System.Windows.Forms.DockStyle.Fill;

            // To
            lblToCaption.AutoSize = true;
            lblToCaption.Text = "To";
            lblToCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtTo.ShowCheckBox = true;
            dtTo.Dock = System.Windows.Forms.DockStyle.Fill;

            // Page
            lblPageCaption.AutoSize = true;
            lblPageCaption.Text = "Page";
            lblPageCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numPage.Minimum = 1;
            numPage.Maximum = 100000;
            numPage.Value = 1;
            numPage.Dock = System.Windows.Forms.DockStyle.Fill;

            // Load button
            btnLoad.Text = "Load";
            btnLoad.AutoSize = true;

            // status
            lblStatus.AutoSize = true;
            lblStatus.Text = "Ready.";
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

            // dgvArchived
            dgvArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchived.AllowUserToAddRows = false;
            dgvArchived.AllowUserToDeleteRows = false;
            dgvArchived.ReadOnly = true;
            dgvArchived.MultiSelect = false;
            dgvArchived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
