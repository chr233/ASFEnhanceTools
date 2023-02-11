namespace ASFEnhanceTools.Forms
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPlugins = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colVersion = new System.Windows.Forms.ColumnHeader();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpASFInfo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvBots = new System.Windows.Forms.ListView();
            this.colBotName = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colBalance = new System.Windows.Forms.ColumnHeader();
            this.colCurrency = new System.Windows.Forms.ColumnHeader();
            this.colSteamId = new System.Windows.Forms.ColumnHeader();
            this.tpPurchase = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSubsInput = new System.Windows.Forms.TextBox();
            this.txtSubsOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGameType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGameDesc = new System.Windows.Forms.TextBox();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.btnQueryAppDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvSubList = new System.Windows.Forms.ListView();
            this.colSubId = new System.Windows.Forms.ColumnHeader();
            this.colSubName = new System.Windows.Forms.ColumnHeader();
            this.colIsFree = new System.Windows.Forms.ColumnHeader();
            this.tpTodo = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBotSelector = new System.Windows.Forms.ComboBox();
            this.btnReloadBots = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpASFInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpPurchase.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPlugins
            // 
            this.lvPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colVersion});
            this.lvPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlugins.FullRowSelect = true;
            this.lvPlugins.Location = new System.Drawing.Point(0, 0);
            this.lvPlugins.Name = "lvPlugins";
            this.lvPlugins.Size = new System.Drawing.Size(527, 169);
            this.lvPlugins.TabIndex = 4;
            this.lvPlugins.UseCompatibleStateImageBehavior = false;
            this.lvPlugins.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "插件名称";
            this.colName.Width = 200;
            // 
            // colVersion
            // 
            this.colVersion.Text = "插件版本";
            this.colVersion.Width = 100;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpASFInfo);
            this.tabControl.Controls.Add(this.tpPurchase);
            this.tabControl.Controls.Add(this.tpTodo);
            this.tabControl.Location = new System.Drawing.Point(3, 37);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(601, 496);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tpASFInfo
            // 
            this.tpASFInfo.Controls.Add(this.splitContainer1);
            this.tpASFInfo.Location = new System.Drawing.Point(4, 26);
            this.tpASFInfo.Name = "tpASFInfo";
            this.tpASFInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpASFInfo.Size = new System.Drawing.Size(533, 466);
            this.tpASFInfo.TabIndex = 0;
            this.tpASFInfo.Text = "ASF 信息";
            this.tpASFInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvBots);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvPlugins);
            this.splitContainer1.Size = new System.Drawing.Size(527, 460);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvBots
            // 
            this.lvBots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBotName,
            this.colNickName,
            this.colStatus,
            this.colBalance,
            this.colCurrency,
            this.colSteamId});
            this.lvBots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBots.FullRowSelect = true;
            this.lvBots.Location = new System.Drawing.Point(0, 0);
            this.lvBots.Name = "lvBots";
            this.lvBots.Size = new System.Drawing.Size(527, 287);
            this.lvBots.TabIndex = 3;
            this.lvBots.UseCompatibleStateImageBehavior = false;
            this.lvBots.View = System.Windows.Forms.View.Details;
            // 
            // colBotName
            // 
            this.colBotName.Text = "机器人名称";
            this.colBotName.Width = 100;
            // 
            // colNickName
            // 
            this.colNickName.Text = "昵称";
            this.colNickName.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "状态";
            this.colStatus.Width = 100;
            // 
            // colBalance
            // 
            this.colBalance.Text = "余额 (小数点)";
            this.colBalance.Width = 100;
            // 
            // colCurrency
            // 
            this.colCurrency.Text = "货币";
            this.colCurrency.Width = 40;
            // 
            // colSteamId
            // 
            this.colSteamId.Text = "Steam Id";
            this.colSteamId.Width = 160;
            // 
            // tpPurchase
            // 
            this.tpPurchase.Controls.Add(this.groupBox2);
            this.tpPurchase.Controls.Add(this.groupBox1);
            this.tpPurchase.Location = new System.Drawing.Point(4, 26);
            this.tpPurchase.Name = "tpPurchase";
            this.tpPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tpPurchase.Size = new System.Drawing.Size(593, 466);
            this.tpPurchase.TabIndex = 1;
            this.tpPurchase.Text = "购物功能";
            this.tpPurchase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnPurchase);
            this.groupBox2.Location = new System.Drawing.Point(7, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "购买游戏";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(44, 22);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtSubsInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtSubsOutput);
            this.splitContainer2.Size = new System.Drawing.Size(531, 197);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 6;
            // 
            // txtSubsInput
            // 
            this.txtSubsInput.AcceptsReturn = true;
            this.txtSubsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubsInput.Location = new System.Drawing.Point(0, 0);
            this.txtSubsInput.Multiline = true;
            this.txtSubsInput.Name = "txtSubsInput";
            this.txtSubsInput.PlaceholderText = "一行一条, 可选前缀 s = sub, b = bundle, 不写前缀默认 sub, 例如 54029";
            this.txtSubsInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubsInput.Size = new System.Drawing.Size(531, 98);
            this.txtSubsInput.TabIndex = 11;
            this.txtSubsInput.WordWrap = false;
            // 
            // txtSubsOutput
            // 
            this.txtSubsOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubsOutput.Location = new System.Drawing.Point(0, 0);
            this.txtSubsOutput.Multiline = true;
            this.txtSubsOutput.Name = "txtSubsOutput";
            this.txtSubsOutput.ReadOnly = true;
            this.txtSubsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubsOutput.Size = new System.Drawing.Size(531, 95);
            this.txtSubsOutput.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "输出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "输入";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPurchase.Location = new System.Drawing.Point(6, 78);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(32, 89);
            this.btnPurchase.TabIndex = 12;
            this.btnPurchase.Text = "&P. 下单";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGameType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGameDesc);
            this.groupBox1.Controls.Add(this.txtGameName);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvSubList);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "获取游戏信息";
            // 
            // txtGameType
            // 
            this.txtGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameType.Location = new System.Drawing.Point(517, 18);
            this.txtGameType.Name = "txtGameType";
            this.txtGameType.PlaceholderText = "类型";
            this.txtGameType.ReadOnly = true;
            this.txtGameType.Size = new System.Drawing.Size(58, 23);
            this.txtGameType.TabIndex = 8;
            this.txtGameType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "双击添加";
            // 
            // txtGameDesc
            // 
            this.txtGameDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDesc.Location = new System.Drawing.Point(210, 47);
            this.txtGameDesc.Multiline = true;
            this.txtGameDesc.Name = "txtGameDesc";
            this.txtGameDesc.PlaceholderText = "游戏简介";
            this.txtGameDesc.ReadOnly = true;
            this.txtGameDesc.Size = new System.Drawing.Size(365, 58);
            this.txtGameDesc.TabIndex = 9;
            // 
            // txtGameName
            // 
            this.txtGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameName.Location = new System.Drawing.Point(210, 18);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.PlaceholderText = "游戏名称";
            this.txtGameName.ReadOnly = true;
            this.txtGameName.Size = new System.Drawing.Size(301, 23);
            this.txtGameName.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAppId);
            this.groupBox3.Controls.Add(this.btnQueryAppDetail);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&AppId";
            // 
            // txtAppId
            // 
            this.txtAppId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAppId.Location = new System.Drawing.Point(6, 22);
            this.txtAppId.MaxLength = 10;
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.PlaceholderText = "单个游戏 AppId";
            this.txtAppId.Size = new System.Drawing.Size(141, 23);
            this.txtAppId.TabIndex = 5;
            this.txtAppId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQueryAppDetail
            // 
            this.btnQueryAppDetail.Location = new System.Drawing.Point(6, 51);
            this.btnQueryAppDetail.Name = "btnQueryAppDetail";
            this.btnQueryAppDetail.Size = new System.Drawing.Size(141, 28);
            this.btnQueryAppDetail.TabIndex = 6;
            this.btnQueryAppDetail.Text = "&Q. 查询信息";
            this.btnQueryAppDetail.UseVisualStyleBackColor = true;
            this.btnQueryAppDetail.Click += new System.EventHandler(this.btnQueryAppDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "简介";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Sub 信息";
            // 
            // lvSubList
            // 
            this.lvSubList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSubList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubId,
            this.colSubName,
            this.colIsFree});
            this.lvSubList.FullRowSelect = true;
            this.lvSubList.Location = new System.Drawing.Point(70, 121);
            this.lvSubList.Name = "lvSubList";
            this.lvSubList.Size = new System.Drawing.Size(505, 96);
            this.lvSubList.TabIndex = 10;
            this.lvSubList.UseCompatibleStateImageBehavior = false;
            this.lvSubList.View = System.Windows.Forms.View.Details;
            this.lvSubList.DoubleClick += new System.EventHandler(this.lvSubList_DoubleClick);
            // 
            // colSubId
            // 
            this.colSubId.Text = "Sub Id";
            // 
            // colSubName
            // 
            this.colSubName.Text = "名称";
            this.colSubName.Width = 300;
            // 
            // colIsFree
            // 
            this.colIsFree.Text = "免费";
            this.colIsFree.Width = 40;
            // 
            // tpTodo
            // 
            this.tpTodo.BackgroundImage = global::ASFEnhanceTools.Properties.Resources.jntm;
            this.tpTodo.Location = new System.Drawing.Point(4, 26);
            this.tpTodo.Name = "tpTodo";
            this.tpTodo.Padding = new System.Windows.Forms.Padding(3);
            this.tpTodo.Size = new System.Drawing.Size(533, 466);
            this.tpTodo.TabIndex = 2;
            this.tpTodo.Text = "开发中……";
            this.tpTodo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "&B. 选择机器人";
            // 
            // cbBotSelector
            // 
            this.cbBotSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBotSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBotSelector.FormattingEnabled = true;
            this.cbBotSelector.Location = new System.Drawing.Point(96, 6);
            this.cbBotSelector.Name = "cbBotSelector";
            this.cbBotSelector.Size = new System.Drawing.Size(424, 25);
            this.cbBotSelector.TabIndex = 0;
            // 
            // btnReloadBots
            // 
            this.btnReloadBots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadBots.Location = new System.Drawing.Point(525, 6);
            this.btnReloadBots.Name = "btnReloadBots";
            this.btnReloadBots.Size = new System.Drawing.Size(75, 25);
            this.btnReloadBots.TabIndex = 1;
            this.btnReloadBots.Text = "&R. 刷新";
            this.btnReloadBots.UseVisualStyleBackColor = true;
            this.btnReloadBots.Click += new System.EventHandler(this.btnReloadBots_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 535);
            this.Controls.Add(this.btnReloadBots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cbBotSelector);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.tabControl.ResumeLayout(false);
            this.tpASFInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tpPurchase.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView lvPlugins;
        private ColumnHeader colName;
        private ColumnHeader colVersion;
        private TabControl tabControl;
        private TabPage tpASFInfo;
        private TabPage tpPurchase;
        private SplitContainer splitContainer1;
        private ListView lvBots;
        private ColumnHeader colBotName;
        private ColumnHeader colNickName;
        private ColumnHeader colStatus;
        private ColumnHeader colSteamId;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label2;
        private ListView lvSubList;
        private Button btnQueryAppDetail;
        private TextBox txtAppId;
        private Label label3;
        private ComboBox cbBotSelector;
        private ColumnHeader colBalance;
        private SplitContainer splitContainer2;
        private TextBox txtSubsInput;
        private TextBox txtSubsOutput;
        private Label label5;
        private Label label4;
        private Button btnPurchase;
        private ColumnHeader colCurrency;
        private Label label7;
        private TextBox txtGameDesc;
        private TextBox txtGameName;
        private GroupBox groupBox3;
        private Label label1;
        private Label label6;
        private ColumnHeader colSubId;
        private ColumnHeader colSubName;
        private ColumnHeader colIsFree;
        private TextBox txtGameType;
        private Button btnReloadBots;
        private TabPage tpTodo;
    }
}