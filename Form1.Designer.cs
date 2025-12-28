namespace SensorSimulatorGui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel urlsLayout;
        private System.Windows.Forms.FlowLayoutPanel urlsButtonsLayout;

        private System.Windows.Forms.Label lblSensorManager;
        private System.Windows.Forms.TextBox txtSensorManagerUrl;
        private System.Windows.Forms.Label lblArchiver;
        private System.Windows.Forms.TextBox txtArchiverUrl;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.TextBox txtControllerUrl;

        private System.Windows.Forms.Button btnApplyUrls;
        private System.Windows.Forms.Button btnReconnectLive;

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnNavSensors;
        private System.Windows.Forms.Button btnNavLive;
        private System.Windows.Forms.Button btnNavArchived;

        private System.Windows.Forms.Panel panelContent;

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

            panelTop = new System.Windows.Forms.Panel();
            urlsLayout = new System.Windows.Forms.TableLayoutPanel();
            urlsButtonsLayout = new System.Windows.Forms.FlowLayoutPanel();

            lblSensorManager = new System.Windows.Forms.Label();
            txtSensorManagerUrl = new System.Windows.Forms.TextBox();
            lblArchiver = new System.Windows.Forms.Label();
            txtArchiverUrl = new System.Windows.Forms.TextBox();
            lblController = new System.Windows.Forms.Label();
            txtControllerUrl = new System.Windows.Forms.TextBox();

            btnApplyUrls = new System.Windows.Forms.Button();
            btnReconnectLive = new System.Windows.Forms.Button();

            splitMain = new System.Windows.Forms.SplitContainer();
            panelNav = new System.Windows.Forms.Panel();
            btnNavSensors = new System.Windows.Forms.Button();
            btnNavLive = new System.Windows.Forms.Button();
            btnNavArchived = new System.Windows.Forms.Button();

            panelContent = new System.Windows.Forms.Panel();

            panelTop.SuspendLayout();
            urlsLayout.SuspendLayout();
            urlsButtonsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panelNav.SuspendLayout();
            SuspendLayout();

            // panelTop
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Height = 88;
            panelTop.Controls.Add(urlsLayout);

            // urlsLayout
            urlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            urlsLayout.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            urlsLayout.ColumnCount = 6;
            urlsLayout.RowCount = 2;
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            urlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            urlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            urlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

            // labels + textboxes
            lblSensorManager.AutoSize = true;
            lblSensorManager.Text = "SensorManager";
            lblSensorManager.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSensorManagerUrl.Dock = System.Windows.Forms.DockStyle.Fill;

            lblArchiver.AutoSize = true;
            lblArchiver.Text = "Archiver";
            lblArchiver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtArchiverUrl.Dock = System.Windows.Forms.DockStyle.Fill;

            lblController.AutoSize = true;
            lblController.Text = "Controller";
            lblController.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtControllerUrl.Dock = System.Windows.Forms.DockStyle.Fill;

            urlsLayout.Controls.Add(lblSensorManager, 0, 0);
            urlsLayout.Controls.Add(txtSensorManagerUrl, 1, 0);
            urlsLayout.Controls.Add(lblArchiver, 2, 0);
            urlsLayout.Controls.Add(txtArchiverUrl, 3, 0);
            urlsLayout.Controls.Add(lblController, 4, 0);
            urlsLayout.Controls.Add(txtControllerUrl, 5, 0);

            // urlsButtonsLayout
            urlsButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            urlsButtonsLayout.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            urlsButtonsLayout.AutoSize = true;

            btnApplyUrls.Text = "Apply URLs";
            btnApplyUrls.AutoSize = true;

            btnReconnectLive.Text = "Reconnect Live";
            btnReconnectLive.AutoSize = true;

            urlsButtonsLayout.Controls.Add(btnApplyUrls);
            urlsButtonsLayout.Controls.Add(btnReconnectLive);

            urlsLayout.Controls.Add(urlsButtonsLayout, 0, 1);
            urlsLayout.SetColumnSpan(urlsButtonsLayout, 6);

            // splitMain
            splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitMain.SplitterDistance = 170;
            splitMain.Panel1.Controls.Add(panelNav);
            splitMain.Panel2.Controls.Add(panelContent);

            // panelNav
            panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            panelNav.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            btnNavSensors.Text = "Sensors";
            btnNavSensors.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavSensors.Height = 44;

            btnNavLive.Text = "Live data";
            btnNavLive.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavLive.Height = 44;

            btnNavArchived.Text = "Archived data";
            btnNavArchived.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavArchived.Height = 44;

            panelNav.Controls.Add(btnNavArchived);
            panelNav.Controls.Add(btnNavLive);
            panelNav.Controls.Add(btnNavSensors);

            // panelContent
            panelContent.Dock = System.Windows.Forms.DockStyle.Fill;

            // Form1
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(splitMain);
            Controls.Add(panelTop);
            MinimumSize = new System.Drawing.Size(950, 600);
            Name = "Form1";
            Text = "Reactor Monitor – GUI Prototype";

            panelTop.ResumeLayout(false);
            urlsLayout.ResumeLayout(false);
            urlsLayout.PerformLayout();
            urlsButtonsLayout.ResumeLayout(false);
            urlsButtonsLayout.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
