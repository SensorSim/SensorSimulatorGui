namespace SensorSimulatorGui.Pages
{
    partial class SensorsPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelGridHost;
        private System.Windows.Forms.Panel panelEditorHost;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.TableLayoutPanel editorLayout;

        private System.Windows.Forms.Label lblSensorId;
        private System.Windows.Forms.TextBox txtSensorId;
        private System.Windows.Forms.Label lblSensorType;
        private System.Windows.Forms.TextBox txtSensorType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;

        private System.Windows.Forms.Label lblOpMin;
        private System.Windows.Forms.NumericUpDown numOperatingMin;
        private System.Windows.Forms.Label lblOpMax;
        private System.Windows.Forms.NumericUpDown numOperatingMax;

        private System.Windows.Forms.Label lblWarnMin;
        private System.Windows.Forms.NumericUpDown numWarningMin;
        private System.Windows.Forms.Label lblWarnMax;
        private System.Windows.Forms.NumericUpDown numWarningMax;

        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown numIntervalMs;

        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.FlowLayoutPanel flagsLayout;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.CheckBox chkSimulate;

        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.FlowLayoutPanel actionsLayout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatus;

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
            splitContainer = new System.Windows.Forms.SplitContainer();
            panelGridHost = new System.Windows.Forms.Panel();
            panelEditorHost = new System.Windows.Forms.Panel();
            dgvSensors = new System.Windows.Forms.DataGridView();
            editorLayout = new System.Windows.Forms.TableLayoutPanel();

            lblSensorId = new System.Windows.Forms.Label();
            txtSensorId = new System.Windows.Forms.TextBox();
            lblSensorType = new System.Windows.Forms.Label();
            txtSensorType = new System.Windows.Forms.TextBox();
            lblUnit = new System.Windows.Forms.Label();
            txtUnit = new System.Windows.Forms.TextBox();

            lblOpMin = new System.Windows.Forms.Label();
            numOperatingMin = new System.Windows.Forms.NumericUpDown();
            lblOpMax = new System.Windows.Forms.Label();
            numOperatingMax = new System.Windows.Forms.NumericUpDown();

            lblWarnMin = new System.Windows.Forms.Label();
            numWarningMin = new System.Windows.Forms.NumericUpDown();
            lblWarnMax = new System.Windows.Forms.Label();
            numWarningMax = new System.Windows.Forms.NumericUpDown();

            lblInterval = new System.Windows.Forms.Label();
            numIntervalMs = new System.Windows.Forms.NumericUpDown();

            lblFlags = new System.Windows.Forms.Label();
            flagsLayout = new System.Windows.Forms.FlowLayoutPanel();
            chkEnabled = new System.Windows.Forms.CheckBox();
            chkSimulate = new System.Windows.Forms.CheckBox();

            lblActions = new System.Windows.Forms.Label();
            actionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();

            lblStatusCaption = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSensors).BeginInit();
            editorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOperatingMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOperatingMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIntervalMs).BeginInit();
            flagsLayout.SuspendLayout();
            actionsLayout.SuspendLayout();
            SuspendLayout();

            // SensorsPage
            BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // splitContainer
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            splitContainer.SplitterDistance = 650;
            splitContainer.SplitterWidth = 8;
            splitContainer.BackColor = System.Drawing.Color.FromArgb(230, 232, 236);
            splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(12);
            splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(12);
            splitContainer.TabIndex = 0;

            // Panel1
            splitContainer.Panel1.Controls.Add(panelGridHost);

            // panelGridHost
            panelGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGridHost.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelGridHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelGridHost.Padding = new System.Windows.Forms.Padding(6);
            panelGridHost.Controls.Add(dgvSensors);

            // dgvSensors
            dgvSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSensors.AllowUserToAddRows = false;
            dgvSensors.AllowUserToDeleteRows = false;
            dgvSensors.MultiSelect = false;
            dgvSensors.ReadOnly = true;
            dgvSensors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSensors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSensors.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvSensors.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgvSensors.RowHeadersVisible = false;
            dgvSensors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSensors.EnableHeadersVisualStyles = false;
            dgvSensors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvSensors.ColumnHeadersHeight = 34;
            dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSensors.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138); // dark blue
            dgvSensors.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvSensors.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            dgvSensors.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvSensors.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254); // light blue
            dgvSensors.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvSensors.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvSensors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSensors.RowTemplate.Height = 30;
            dgvSensors.Name = "dgvSensors";
            dgvSensors.TabIndex = 0;

            // Panel2
            splitContainer.Panel2.Controls.Add(panelEditorHost);

            // panelEditorHost
            panelEditorHost.Dock = System.Windows.Forms.DockStyle.Fill;
            panelEditorHost.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            panelEditorHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelEditorHost.Controls.Add(editorLayout);

            // editorLayout
            editorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            editorLayout.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            editorLayout.Padding = new System.Windows.Forms.Padding(14);
            editorLayout.ColumnCount = 2;
            editorLayout.RowCount = 11;
            editorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                        editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            editorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

            // SensorId
            lblSensorId.AutoSize = true;
            lblSensorId.Text = "SensorId";
            lblSensorId.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblSensorId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSensorId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSensorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // SensorType
            lblSensorType.AutoSize = true;
            lblSensorType.Text = "SensorType";
            lblSensorType.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblSensorType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSensorType.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSensorType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Unit
            lblUnit.AutoSize = true;
            lblUnit.Text = "Unit";
            lblUnit.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // OperatingMin
            lblOpMin.AutoSize = true;
            lblOpMin.Text = "OperatingMin";
            lblOpMin.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblOpMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numOperatingMin.DecimalPlaces = 3;
            numOperatingMin.Minimum = 0;
            numOperatingMin.Maximum = 100000;
            numOperatingMin.Increment = 0.1M;
            numOperatingMin.Dock = System.Windows.Forms.DockStyle.Left;
            numOperatingMin.Width = 140;

            // OperatingMax
            lblOpMax.AutoSize = true;
            lblOpMax.Text = "OperatingMax";
            lblOpMax.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblOpMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numOperatingMax.DecimalPlaces = 3;
            numOperatingMax.Minimum = 0;
            numOperatingMax.Maximum = 100000;
            numOperatingMax.Increment = 0.1M;
            numOperatingMax.Dock = System.Windows.Forms.DockStyle.Left;
            numOperatingMax.Width = 140;

            // WarningMin
            lblWarnMin.AutoSize = true;
            lblWarnMin.Text = "WarningMin";
            lblWarnMin.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblWarnMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numWarningMin.DecimalPlaces = 3;
            numWarningMin.Minimum = 0;
            numWarningMin.Maximum = 100000;
            numWarningMin.Increment = 0.1M;
            numWarningMin.Dock = System.Windows.Forms.DockStyle.Left;
            numWarningMin.Width = 140;

            // WarningMax
            lblWarnMax.AutoSize = true;
            lblWarnMax.Text = "WarningMax";
            lblWarnMax.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblWarnMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numWarningMax.DecimalPlaces = 3;
            numWarningMax.Minimum = 0;
            numWarningMax.Maximum = 100000;
            numWarningMax.Increment = 0.1M;
            numWarningMax.Dock = System.Windows.Forms.DockStyle.Left;
            numWarningMax.Width = 140;

            // IntervalMs
            lblInterval.AutoSize = true;
            lblInterval.Text = "IntervalMs";
            lblInterval.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numIntervalMs.Minimum = 100;
            numIntervalMs.Maximum = 600000;
            numIntervalMs.Increment = 100;
            numIntervalMs.Value = 1000;
            numIntervalMs.Dock = System.Windows.Forms.DockStyle.Left;
            numIntervalMs.Width = 140;

            // Flags
            lblFlags.AutoSize = true;
            lblFlags.Text = "Flags";
            lblFlags.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblFlags.Anchor = System.Windows.Forms.AnchorStyles.Left;

            flagsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            flagsLayout.AutoSize = true;
            flagsLayout.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            chkEnabled.Text = "Enabled";
            chkEnabled.AutoSize = true;
            chkEnabled.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            chkSimulate.Text = "Simulate";
            chkSimulate.AutoSize = true;
            chkSimulate.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            flagsLayout.Controls.Add(chkEnabled);
            flagsLayout.Controls.Add(chkSimulate);

            // Actions
            lblActions.AutoSize = true;
            lblActions.Text = "Actions";
            lblActions.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblActions.Anchor = System.Windows.Forms.AnchorStyles.Left;

            actionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            actionsLayout.AutoSize = true;
            actionsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            actionsLayout.WrapContents = false;
            actionsLayout.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            btnAdd.Text = "Add";
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Size = new System.Drawing.Size(140, 34);
            btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            btnUpdate.Text = "Update";
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Size = new System.Drawing.Size(140, 34);
            btnUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            btnDelete.Text = "Delete";
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 40, 217);
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Size = new System.Drawing.Size(140, 34);
            btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            btnRefresh.Text = "Refresh";
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Size = new System.Drawing.Size(140, 34);
            btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);



            actionsLayout.Controls.Add(btnAdd);
            actionsLayout.Controls.Add(btnUpdate);
            actionsLayout.Controls.Add(btnDelete);
            actionsLayout.Controls.Add(btnRefresh);

            // Status
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Text = "Status";
            lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            lblStatusCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;

            lblStatus.AutoSize = true;
            lblStatus.Text = "Ready.";
            lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);

            // Add to editorLayout
            editorLayout.Controls.Add(lblSensorId, 0, 0);
            editorLayout.Controls.Add(txtSensorId, 1, 0);
            editorLayout.Controls.Add(lblSensorType, 0, 1);
            editorLayout.Controls.Add(txtSensorType, 1, 1);
            editorLayout.Controls.Add(lblUnit, 0, 2);
            editorLayout.Controls.Add(txtUnit, 1, 2);

            editorLayout.Controls.Add(lblOpMin, 0, 3);
            editorLayout.Controls.Add(numOperatingMin, 1, 3);
            editorLayout.Controls.Add(lblOpMax, 0, 4);
            editorLayout.Controls.Add(numOperatingMax, 1, 4);

            editorLayout.Controls.Add(lblWarnMin, 0, 5);
            editorLayout.Controls.Add(numWarningMin, 1, 5);
            editorLayout.Controls.Add(lblWarnMax, 0, 6);
            editorLayout.Controls.Add(numWarningMax, 1, 6);

            editorLayout.Controls.Add(lblInterval, 0, 7);
            editorLayout.Controls.Add(numIntervalMs, 1, 7);

            editorLayout.Controls.Add(lblFlags, 0, 8);
            editorLayout.Controls.Add(flagsLayout, 1, 8);

            editorLayout.Controls.Add(lblActions, 0, 9);
            editorLayout.Controls.Add(actionsLayout, 1, 9);

            editorLayout.Controls.Add(lblStatusCaption, 0, 10);
            editorLayout.Controls.Add(lblStatus, 1, 10);

            // SensorsPage
            Controls.Add(splitContainer);
            Name = "SensorsPage";
            Size = new System.Drawing.Size(1000, 600);

            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSensors).EndInit();
            editorLayout.ResumeLayout(false);
            editorLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOperatingMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOperatingMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIntervalMs).EndInit();
            flagsLayout.ResumeLayout(false);
            flagsLayout.PerformLayout();
            actionsLayout.ResumeLayout(false);
            actionsLayout.PerformLayout();
            ResumeLayout(false);
        }
    }
}
