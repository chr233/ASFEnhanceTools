namespace ASFEnhanceTools.Forms
{
    partial class FormConnector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetASFEnhance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnCheckASFEToolsUpdate = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblGitHub = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAfadian = new System.Windows.Forms.Button();
            this.btnSteam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetASFEnhance
            // 
            this.btnGetASFEnhance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetASFEnhance.Location = new System.Drawing.Point(12, 101);
            this.btnGetASFEnhance.Name = "btnGetASFEnhance";
            this.btnGetASFEnhance.Size = new System.Drawing.Size(140, 37);
            this.btnGetASFEnhance.TabIndex = 5;
            this.btnGetASFEnhance.Text = "获取 ASFEnhance";
            this.btnGetASFEnhance.UseVisualStyleBackColor = true;
            this.btnGetASFEnhance.Click += new System.EventHandler(this.btnGetASFEnhance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnTestConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASF &IPC 设置";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 22);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "&A. IPC 地址";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "&P. IPC 密码";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(82, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "http://localhost:1242";
            this.txtAddress.Size = new System.Drawing.Size(226, 23);
            this.txtAddress.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(82, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "默认为空";
            this.txtPassword.Size = new System.Drawing.Size(226, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Location = new System.Drawing.Point(314, 19);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(190, 53);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "&C. 开始连接";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnCheckASFEToolsUpdate
            // 
            this.btnCheckASFEToolsUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckASFEToolsUpdate.Location = new System.Drawing.Point(158, 101);
            this.btnCheckASFEToolsUpdate.Name = "btnCheckASFEToolsUpdate";
            this.btnCheckASFEToolsUpdate.Size = new System.Drawing.Size(140, 37);
            this.btnCheckASFEToolsUpdate.TabIndex = 6;
            this.btnCheckASFEToolsUpdate.Text = "检查 ASFE Tools 更新";
            this.btnCheckASFEToolsUpdate.UseVisualStyleBackColor = true;
            this.btnCheckASFEToolsUpdate.Click += new System.EventHandler(this.btnCheckASFEToolsUpdate_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLbl1,
            this.tsLblVersion,
            this.toolStripStatusLabel2,
            this.tsLblGitHub});
            this.ssBar.Location = new System.Drawing.Point(0, 151);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(534, 22);
            this.ssBar.TabIndex = 1;
            this.ssBar.Text = "状态栏";
            // 
            // tsLbl1
            // 
            this.tsLbl1.Name = "tsLbl1";
            this.tsLbl1.Size = new System.Drawing.Size(56, 17);
            this.tsLbl1.Text = "软件版本";
            // 
            // tsLblVersion
            // 
            this.tsLblVersion.Name = "tsLblVersion";
            this.tsLblVersion.Size = new System.Drawing.Size(45, 17);
            this.tsLblVersion.Text = "0.0.0.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(351, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // tsLblGitHub
            // 
            this.tsLblGitHub.IsLink = true;
            this.tsLblGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tsLblGitHub.Name = "tsLblGitHub";
            this.tsLblGitHub.Size = new System.Drawing.Size(67, 17);
            this.tsLblGitHub.Text = "By Chr233";
            this.tsLblGitHub.Click += new System.EventHandler(this.tsLblGitHub_Click);
            // 
            // btnAfadian
            // 
            this.btnAfadian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfadian.Location = new System.Drawing.Point(429, 101);
            this.btnAfadian.Name = "btnAfadian";
            this.btnAfadian.Size = new System.Drawing.Size(93, 37);
            this.btnAfadian.TabIndex = 4;
            this.btnAfadian.Text = "爱发电";
            this.btnAfadian.UseVisualStyleBackColor = true;
            this.btnAfadian.Click += new System.EventHandler(this.btnAfadian_Click);
            // 
            // btnSteam
            // 
            this.btnSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSteam.Location = new System.Drawing.Point(332, 101);
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.Size = new System.Drawing.Size(91, 37);
            this.btnSteam.TabIndex = 3;
            this.btnSteam.Text = "Steam 主页";
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // FormConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 173);
            this.Controls.Add(this.btnSteam);
            this.Controls.Add(this.btnAfadian);
            this.Controls.Add(this.btnGetASFEnhance);
            this.Controls.Add(this.btnCheckASFEToolsUpdate);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASFEnhance Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnector_FormClosing);
            this.Load += new System.EventHandler(this.FormConnector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGetASFEnhance;
        private Button btnTestConnection;
        private Label lblPassword;
        private Label lblAddress;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private StatusStrip ssBar;
        private GroupBox groupBox1;
        private Button btnCheckASFEToolsUpdate;
        private ToolStripStatusLabel tsLbl1;
        private ToolStripStatusLabel tsLblVersion;
        private Button btnAfadian;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tsLblGitHub;
        private Button btnSteam;
    }
}