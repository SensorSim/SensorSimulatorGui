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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer = new SplitContainer();
            panelGridHost = new Panel();
            dgvSensors = new DataGridView();
            panelEditorHost = new Panel();
            editorLayout = new TableLayoutPanel();
            lblSensorId = new Label();
            txtSensorId = new TextBox();
            lblSensorType = new Label();
            txtSensorType = new TextBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblOpMin = new Label();
            numOperatingMin = new NumericUpDown();
            lblOpMax = new Label();
            numOperatingMax = new NumericUpDown();
            lblWarnMin = new Label();
            numWarningMin = new NumericUpDown();
            lblWarnMax = new Label();
            numWarningMax = new NumericUpDown();
            lblInterval = new Label();
            numIntervalMs = new NumericUpDown();
            lblFlags = new Label();
            flagsLayout = new FlowLayoutPanel();
            chkEnabled = new CheckBox();
            chkSimulate = new CheckBox();
            lblActions = new Label();
            actionsLayout = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblStatusCaption = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSensors).BeginInit();
            panelEditorHost.SuspendLayout();
            editorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOperatingMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOperatingMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWarningMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIntervalMs).BeginInit();
            flagsLayout.SuspendLayout();
            actionsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(71, 85, 105);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(30, 41, 59);
            splitContainer.Panel1.Controls.Add(panelGridHost);
            splitContainer.Panel1.Padding = new Padding(12);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.FromArgb(30, 41, 59);
            splitContainer.Panel2.Controls.Add(panelEditorHost);
            splitContainer.Panel2.Padding = new Padding(12);
            splitContainer.Size = new Size(1048, 600);
            splitContainer.SplitterDistance = 729;
            splitContainer.SplitterWidth = 8;
            splitContainer.TabIndex = 0;
            // 
            // panelGridHost
            // 
            panelGridHost.BackColor = Color.FromArgb(37, 51, 71);
            panelGridHost.BorderStyle = BorderStyle.FixedSingle;
            panelGridHost.Controls.Add(dgvSensors);
            panelGridHost.Dock = DockStyle.Fill;
            panelGridHost.Location = new Point(12, 12);
            panelGridHost.Name = "panelGridHost";
            panelGridHost.Padding = new Padding(6);
            panelGridHost.Size = new Size(705, 576);
            panelGridHost.TabIndex = 0;
            // 
            // dgvSensors
            // 
            dgvSensors.AllowUserToAddRows = false;
            dgvSensors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 59, 79);
            dgvSensors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSensors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSensors.BackgroundColor = Color.FromArgb(37, 51, 71);
            dgvSensors.BorderStyle = BorderStyle.None;
            dgvSensors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSensors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSensors.ColumnHeadersHeight = 34;
            dgvSensors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 51, 71);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(196, 181, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSensors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSensors.Dock = DockStyle.Fill;
            dgvSensors.EnableHeadersVisualStyles = false;
            dgvSensors.GridColor = Color.FromArgb(71, 85, 105);
            dgvSensors.Location = new Point(6, 6);
            dgvSensors.MultiSelect = false;
            dgvSensors.Name = "dgvSensors";
            dgvSensors.ReadOnly = true;
            dgvSensors.RowHeadersVisible = false;
            dgvSensors.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 51, 71);
            dgvSensors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSensors.RowTemplate.Height = 30;
            dgvSensors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSensors.Size = new Size(691, 562);
            dgvSensors.TabIndex = 0;
            // 
            // panelEditorHost
            // 
            panelEditorHost.BackColor = Color.FromArgb(37, 51, 71);
            panelEditorHost.BorderStyle = BorderStyle.FixedSingle;
            panelEditorHost.Controls.Add(editorLayout);
            panelEditorHost.Dock = DockStyle.Fill;
            panelEditorHost.Location = new Point(12, 12);
            panelEditorHost.Name = "panelEditorHost";
            panelEditorHost.Size = new Size(287, 576);
            panelEditorHost.TabIndex = 0;
            // 
            // editorLayout
            // 
            editorLayout.BackColor = Color.FromArgb(37, 51, 71);
            editorLayout.ColumnCount = 2;
            editorLayout.ColumnStyles.Add(new ColumnStyle());
            editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            editorLayout.Controls.Add(lblStatus, 1, 10);
            editorLayout.Controls.Add(lblStatusCaption, 0, 10);
            editorLayout.Dock = DockStyle.Fill;
            editorLayout.Location = new Point(0, 0);
            editorLayout.Name = "editorLayout";
            editorLayout.Padding = new Padding(14);
            editorLayout.RowCount = 11;
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.RowStyles.Add(new RowStyle());
            editorLayout.Size = new Size(285, 574);
            editorLayout.TabIndex = 0;
            // 
            // lblSensorId
            // 
            lblSensorId.Anchor = AnchorStyles.Left;
            lblSensorId.AutoSize = true;
            lblSensorId.ForeColor = Color.FromArgb(226, 232, 240);
            lblSensorId.Location = new Point(17, 20);
            lblSensorId.Name = "lblSensorId";
            lblSensorId.Size = new Size(66, 20);
            lblSensorId.TabIndex = 0;
            lblSensorId.Text = "SensorId";
            // 
            // txtSensorId
            // 
            txtSensorId.BackColor = Color.FromArgb(51, 65, 85);
            txtSensorId.BorderStyle = BorderStyle.FixedSingle;
            txtSensorId.Dock = DockStyle.Fill;
            txtSensorId.ForeColor = Color.FromArgb(226, 232, 240);
            txtSensorId.Location = new Point(127, 17);
            txtSensorId.Name = "txtSensorId";
            txtSensorId.Size = new Size(141, 27);
            txtSensorId.TabIndex = 1;
            // 
            // lblSensorType
            // 
            lblSensorType.Anchor = AnchorStyles.Left;
            lblSensorType.AutoSize = true;
            lblSensorType.ForeColor = Color.FromArgb(226, 232, 240);
            lblSensorType.Location = new Point(17, 53);
            lblSensorType.Name = "lblSensorType";
            lblSensorType.Size = new Size(84, 20);
            lblSensorType.TabIndex = 2;
            lblSensorType.Text = "SensorType";
            // 
            // txtSensorType
            // 
            txtSensorType.BackColor = Color.FromArgb(51, 65, 85);
            txtSensorType.BorderStyle = BorderStyle.FixedSingle;
            txtSensorType.Dock = DockStyle.Fill;
            txtSensorType.ForeColor = Color.FromArgb(226, 232, 240);
            txtSensorType.Location = new Point(127, 50);
            txtSensorType.Name = "txtSensorType";
            txtSensorType.Size = new Size(141, 27);
            txtSensorType.TabIndex = 3;
            // 
            // lblUnit
            // 
            lblUnit.Anchor = AnchorStyles.Left;
            lblUnit.AutoSize = true;
            lblUnit.ForeColor = Color.FromArgb(226, 232, 240);
            lblUnit.Location = new Point(17, 86);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(36, 20);
            lblUnit.TabIndex = 4;
            lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.FromArgb(51, 65, 85);
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Dock = DockStyle.Fill;
            txtUnit.ForeColor = Color.FromArgb(226, 232, 240);
            txtUnit.Location = new Point(127, 83);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(141, 27);
            txtUnit.TabIndex = 5;
            // 
            // lblOpMin
            // 
            lblOpMin.Anchor = AnchorStyles.Left;
            lblOpMin.AutoSize = true;
            lblOpMin.ForeColor = Color.FromArgb(226, 232, 240);
            lblOpMin.Location = new Point(17, 119);
            lblOpMin.Name = "lblOpMin";
            lblOpMin.Size = new Size(101, 20);
            lblOpMin.TabIndex = 6;
            lblOpMin.Text = "OperatingMin";
            // 
            // numOperatingMin
            // 
            numOperatingMin.BackColor = Color.FromArgb(51, 65, 85);
            numOperatingMin.DecimalPlaces = 3;
            numOperatingMin.Dock = DockStyle.Left;
            numOperatingMin.ForeColor = Color.FromArgb(226, 232, 240);
            numOperatingMin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numOperatingMin.Location = new Point(127, 116);
            numOperatingMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numOperatingMin.Name = "numOperatingMin";
            numOperatingMin.Size = new Size(140, 27);
            numOperatingMin.TabIndex = 7;
            // 
            // lblOpMax
            // 
            lblOpMax.Anchor = AnchorStyles.Left;
            lblOpMax.AutoSize = true;
            lblOpMax.ForeColor = Color.FromArgb(226, 232, 240);
            lblOpMax.Location = new Point(17, 152);
            lblOpMax.Name = "lblOpMax";
            lblOpMax.Size = new Size(104, 20);
            lblOpMax.TabIndex = 8;
            lblOpMax.Text = "OperatingMax";
            // 
            // numOperatingMax
            // 
            numOperatingMax.BackColor = Color.FromArgb(51, 65, 85);
            numOperatingMax.DecimalPlaces = 3;
            numOperatingMax.Dock = DockStyle.Left;
            numOperatingMax.ForeColor = Color.FromArgb(226, 232, 240);
            numOperatingMax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numOperatingMax.Location = new Point(127, 149);
            numOperatingMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numOperatingMax.Name = "numOperatingMax";
            numOperatingMax.Size = new Size(140, 27);
            numOperatingMax.TabIndex = 9;
            // 
            // lblWarnMin
            // 
            lblWarnMin.Anchor = AnchorStyles.Left;
            lblWarnMin.AutoSize = true;
            lblWarnMin.ForeColor = Color.FromArgb(226, 232, 240);
            lblWarnMin.Location = new Point(17, 185);
            lblWarnMin.Name = "lblWarnMin";
            lblWarnMin.Size = new Size(89, 20);
            lblWarnMin.TabIndex = 10;
            lblWarnMin.Text = "WarningMin";
            // 
            // numWarningMin
            // 
            numWarningMin.BackColor = Color.FromArgb(51, 65, 85);
            numWarningMin.DecimalPlaces = 3;
            numWarningMin.Dock = DockStyle.Left;
            numWarningMin.ForeColor = Color.FromArgb(226, 232, 240);
            numWarningMin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numWarningMin.Location = new Point(127, 182);
            numWarningMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numWarningMin.Name = "numWarningMin";
            numWarningMin.Size = new Size(140, 27);
            numWarningMin.TabIndex = 11;
            // 
            // lblWarnMax
            // 
            lblWarnMax.Anchor = AnchorStyles.Left;
            lblWarnMax.AutoSize = true;
            lblWarnMax.ForeColor = Color.FromArgb(226, 232, 240);
            lblWarnMax.Location = new Point(17, 218);
            lblWarnMax.Name = "lblWarnMax";
            lblWarnMax.Size = new Size(92, 20);
            lblWarnMax.TabIndex = 12;
            lblWarnMax.Text = "WarningMax";
            // 
            // numWarningMax
            // 
            numWarningMax.BackColor = Color.FromArgb(51, 65, 85);
            numWarningMax.DecimalPlaces = 3;
            numWarningMax.Dock = DockStyle.Left;
            numWarningMax.ForeColor = Color.FromArgb(226, 232, 240);
            numWarningMax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numWarningMax.Location = new Point(127, 215);
            numWarningMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numWarningMax.Name = "numWarningMax";
            numWarningMax.Size = new Size(140, 27);
            numWarningMax.TabIndex = 13;
            // 
            // lblInterval
            // 
            lblInterval.Anchor = AnchorStyles.Left;
            lblInterval.AutoSize = true;
            lblInterval.ForeColor = Color.FromArgb(226, 232, 240);
            lblInterval.Location = new Point(17, 251);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(77, 20);
            lblInterval.TabIndex = 14;
            lblInterval.Text = "IntervalMs";
            // 
            // numIntervalMs
            // 
            numIntervalMs.BackColor = Color.FromArgb(51, 65, 85);
            numIntervalMs.Dock = DockStyle.Left;
            numIntervalMs.ForeColor = Color.FromArgb(226, 232, 240);
            numIntervalMs.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numIntervalMs.Location = new Point(127, 248);
            numIntervalMs.Maximum = new decimal(new int[] { 600000, 0, 0, 0 });
            numIntervalMs.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numIntervalMs.Name = "numIntervalMs";
            numIntervalMs.Size = new Size(140, 27);
            numIntervalMs.TabIndex = 15;
            numIntervalMs.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblFlags
            // 
            lblFlags.Anchor = AnchorStyles.Left;
            lblFlags.AutoSize = true;
            lblFlags.ForeColor = Color.FromArgb(226, 232, 240);
            lblFlags.Location = new Point(17, 301);
            lblFlags.Name = "lblFlags";
            lblFlags.Size = new Size(43, 20);
            lblFlags.TabIndex = 16;
            lblFlags.Text = "Flags";
            // 
            // flagsLayout
            // 
            flagsLayout.AutoSize = true;
            flagsLayout.BackColor = Color.FromArgb(37, 51, 71);
            flagsLayout.Controls.Add(chkEnabled);
            flagsLayout.Controls.Add(chkSimulate);
            flagsLayout.Dock = DockStyle.Fill;
            flagsLayout.Location = new Point(127, 281);
            flagsLayout.Name = "flagsLayout";
            flagsLayout.Size = new Size(141, 60);
            flagsLayout.TabIndex = 17;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.ForeColor = Color.FromArgb(226, 232, 240);
            chkEnabled.Location = new Point(3, 3);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(85, 24);
            chkEnabled.TabIndex = 0;
            chkEnabled.Text = "Enabled";
            // 
            // chkSimulate
            // 
            chkSimulate.AutoSize = true;
            chkSimulate.ForeColor = Color.FromArgb(226, 232, 240);
            chkSimulate.Location = new Point(3, 33);
            chkSimulate.Name = "chkSimulate";
            chkSimulate.Size = new Size(89, 24);
            chkSimulate.TabIndex = 1;
            chkSimulate.Text = "Simulate";
            // 
            // lblActions
            // 
            lblActions.Anchor = AnchorStyles.Left;
            lblActions.AutoSize = true;
            lblActions.ForeColor = Color.FromArgb(226, 232, 240);
            lblActions.Location = new Point(17, 422);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(58, 20);
            lblActions.TabIndex = 18;
            lblActions.Text = "Actions";
            // 
            // actionsLayout
            // 
            actionsLayout.AutoSize = true;
            actionsLayout.Controls.Add(btnAdd);
            actionsLayout.Controls.Add(btnUpdate);
            actionsLayout.Controls.Add(btnDelete);
            actionsLayout.Controls.Add(btnRefresh);
            actionsLayout.Dock = DockStyle.Fill;
            actionsLayout.FlowDirection = FlowDirection.TopDown;
            actionsLayout.Location = new Point(127, 347);
            actionsLayout.Name = "actionsLayout";
            actionsLayout.Padding = new Padding(0, 2, 0, 0);
            actionsLayout.Size = new Size(141, 170);
            actionsLayout.TabIndex = 19;
            actionsLayout.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(59, 130, 246);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 2);
            btnAdd.Margin = new Padding(0, 0, 0, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(30, 58, 138);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 44);
            btnUpdate.Margin = new Padding(0, 0, 0, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(124, 58, 237);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 40, 217);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 86);
            btnDelete.Margin = new Padding(0, 0, 0, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(44, 59, 79);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(226, 232, 240);
            btnRefresh.Location = new Point(0, 128);
            btnRefresh.Margin = new Padding(0, 0, 0, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Anchor = AnchorStyles.Left;
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.ForeColor = Color.FromArgb(226, 232, 240);
            lblStatusCaption.Location = new Point(17, 530);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(49, 20);
            lblStatusCaption.TabIndex = 20;
            lblStatusCaption.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(226, 232, 240);
            lblStatus.Location = new Point(127, 520);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(141, 40);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "Ready.";
            // 
            // SensorsPage
            // 
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(splitContainer);
            Name = "SensorsPage";
            Size = new Size(1048, 600);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSensors).EndInit();
            panelEditorHost.ResumeLayout(false);
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
            ResumeLayout(false);
        }
    }
}