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
            btnGetASFEnhance = new Button();
            groupBox1 = new GroupBox();
            chkSavePasswd = new CheckBox();
            lblAddress = new Label();
            lblPassword = new Label();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            btnTestConnection = new Button();
            btnCheckASFEToolsUpdate = new Button();
            ssBar = new StatusStrip();
            tsLbl1 = new ToolStripStatusLabel();
            tsLblVersion = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            tsLblGitHub = new ToolStripStatusLabel();
            btnAfadian = new Button();
            btnSteam = new Button();
            groupBox1.SuspendLayout();
            ssBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetASFEnhance
            // 
            btnGetASFEnhance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetASFEnhance.Location = new Point(16, 99);
            btnGetASFEnhance.Name = "btnGetASFEnhance";
            btnGetASFEnhance.Size = new Size(140, 37);
            btnGetASFEnhance.TabIndex = 4;
            btnGetASFEnhance.TabStop = false;
            btnGetASFEnhance.Text = "获取 ASFEnhance";
            btnGetASFEnhance.UseVisualStyleBackColor = true;
            btnGetASFEnhance.Click += btnGetASFEnhance_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(chkSavePasswd);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnTestConnection);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 81);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ASF &IPC 设置";
            // 
            // chkSavePasswd
            // 
            chkSavePasswd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSavePasswd.AutoSize = true;
            chkSavePasswd.Location = new Point(231, 50);
            chkSavePasswd.Name = "chkSavePasswd";
            chkSavePasswd.Size = new Size(75, 21);
            chkSavePasswd.TabIndex = 2;
            chkSavePasswd.Text = "记住密码";
            chkSavePasswd.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(6, 22);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 17);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "&A. IPC 地址";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 51);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "&P. IPC 密码";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(82, 19);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "http://localhost:1242";
            txtAddress.Size = new Size(224, 23);
            txtAddress.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(82, 48);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "默认为空";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTestConnection.Location = new Point(312, 19);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(190, 52);
            btnTestConnection.TabIndex = 3;
            btnTestConnection.Text = "&C. 开始连接";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // btnCheckASFEToolsUpdate
            // 
            btnCheckASFEToolsUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckASFEToolsUpdate.Location = new Point(162, 99);
            btnCheckASFEToolsUpdate.Name = "btnCheckASFEToolsUpdate";
            btnCheckASFEToolsUpdate.Size = new Size(140, 37);
            btnCheckASFEToolsUpdate.TabIndex = 5;
            btnCheckASFEToolsUpdate.TabStop = false;
            btnCheckASFEToolsUpdate.Text = "检查 ASFE Tools 更新";
            btnCheckASFEToolsUpdate.UseVisualStyleBackColor = true;
            btnCheckASFEToolsUpdate.Click += btnCheckASFEToolsUpdate_Click;
            // 
            // ssBar
            // 
            ssBar.Items.AddRange(new ToolStripItem[] { tsLbl1, tsLblVersion, toolStripStatusLabel2, tsLblGitHub });
            ssBar.Location = new Point(0, 146);
            ssBar.Name = "ssBar";
            ssBar.Size = new Size(532, 22);
            ssBar.SizingGrip = false;
            ssBar.TabIndex = 1;
            ssBar.Text = "状态栏";
            // 
            // tsLbl1
            // 
            tsLbl1.Name = "tsLbl1";
            tsLbl1.Size = new Size(32, 17);
            tsLbl1.Text = "版本";
            // 
            // tsLblVersion
            // 
            tsLblVersion.Name = "tsLblVersion";
            tsLblVersion.Size = new Size(45, 17);
            tsLblVersion.Text = "0.0.0.0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(349, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // tsLblGitHub
            // 
            tsLblGitHub.IsLink = true;
            tsLblGitHub.LinkBehavior = LinkBehavior.HoverUnderline;
            tsLblGitHub.LinkColor = Color.Black;
            tsLblGitHub.Name = "tsLblGitHub";
            tsLblGitHub.Size = new Size(67, 17);
            tsLblGitHub.Text = "By Chr233";
            tsLblGitHub.VisitedLinkColor = Color.Black;
            tsLblGitHub.Click += tsLblGitHub_Click;
            // 
            // btnAfadian
            // 
            btnAfadian.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAfadian.Location = new Point(421, 99);
            btnAfadian.Name = "btnAfadian";
            btnAfadian.Size = new Size(93, 37);
            btnAfadian.TabIndex = 7;
            btnAfadian.TabStop = false;
            btnAfadian.Text = "爱发电";
            btnAfadian.UseVisualStyleBackColor = true;
            btnAfadian.Click += btnAfadian_Click;
            // 
            // btnSteam
            // 
            btnSteam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSteam.Location = new Point(324, 99);
            btnSteam.Name = "btnSteam";
            btnSteam.Size = new Size(91, 37);
            btnSteam.TabIndex = 6;
            btnSteam.TabStop = false;
            btnSteam.Text = "Steam 主页";
            btnSteam.UseVisualStyleBackColor = true;
            btnSteam.Click += btnSteam_Click;
            // 
            // FormConnector
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 168);
            Controls.Add(btnSteam);
            Controls.Add(btnAfadian);
            Controls.Add(btnGetASFEnhance);
            Controls.Add(btnCheckASFEToolsUpdate);
            Controls.Add(ssBar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConnector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASFEnhance Tools";
            FormClosing += FormConnector_FormClosing;
            Load += FormConnector_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ssBar.ResumeLayout(false);
            ssBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox chkSavePasswd;
    }
}