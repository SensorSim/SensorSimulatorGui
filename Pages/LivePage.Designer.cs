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

        private System.Windows.Forms.DataGridView dgvLive;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSensorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimestamp;

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

            dgvLive = new System.Windows.Forms.DataGridView();

            colSensorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();

            mainLayout.SuspendLayout();
            headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLive).BeginInit();
            SuspendLayout();

            // mainLayout
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerLayout, 0, 0);
            mainLayout.Controls.Add(dgvLive, 0, 1);

            // headerLayout
            headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            headerLayout.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            headerLayout.ColumnCount = 7;
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));

            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Text = "Filter SensorId";
            lblFilterCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;

            txtFilterSensorId.Dock = System.Windows.Forms.DockStyle.Fill;

            btnClearFilter.Text = "Clear";
            btnClearFilter.AutoSize = true;

            btnReconnect.Text = "Reconnect";
            btnReconnect.AutoSize = true;

            lblSpacer.AutoSize = true;
            lblSpacer.Text = "";
            
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Text = "Status:";
            lblStatusCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;

            lblStatus.AutoSize = true;
            lblStatus.Text = "disconnected";
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;

            headerLayout.Controls.Add(lblFilterCaption, 0, 0);
            headerLayout.Controls.Add(txtFilterSensorId, 1, 0);
            headerLayout.Controls.Add(btnClearFilter, 2, 0);
            headerLayout.Controls.Add(btnReconnect, 3, 0);
            headerLayout.Controls.Add(lblSpacer, 4, 0);
            headerLayout.Controls.Add(lblStatusCaption, 5, 0);
            headerLayout.Controls.Add(lblStatus, 6, 0);

            // dgvLive
            dgvLive.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLive.AllowUserToAddRows = false;
            dgvLive.AllowUserToDeleteRows = false;
            dgvLive.ReadOnly = true;
            dgvLive.MultiSelect = false;
            dgvLive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLive.AutoGenerateColumns = false;
            dgvLive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colSensorId,
                colValue,
                colTimestamp
            });
            dgvLive.Name = "dgvLive";
            dgvLive.TabIndex = 0;

            // columns
            colSensorId.HeaderText = "SensorId";
            colSensorId.DataPropertyName = "SensorId";
            colSensorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            colValue.HeaderText = "Value";
            colValue.DataPropertyName = "Value";
            colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            colTimestamp.HeaderText = "Timestamp";
            colTimestamp.DataPropertyName = "Timestamp";
            colTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            // LivePage
            Controls.Add(mainLayout);
            Name = "LivePage";
            Size = new System.Drawing.Size(1000, 600);

            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            headerLayout.ResumeLayout(false);
            headerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLive).EndInit();
            ResumeLayout(false);
        }
    }
}
