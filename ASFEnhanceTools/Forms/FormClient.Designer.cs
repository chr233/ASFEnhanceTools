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
            lvPlugins = new ListView();
            colName = new ColumnHeader();
            colVersion = new ColumnHeader();
            tabControl = new TabControl();
            tpASFInfo = new TabPage();
            splitContainer1 = new SplitContainer();
            lvBots = new ListView();
            colBotName = new ColumnHeader();
            colNickName = new ColumnHeader();
            colStatus = new ColumnHeader();
            colBalance = new ColumnHeader();
            colCurrency = new ColumnHeader();
            colSteamId = new ColumnHeader();
            tpGameInfo = new TabPage();
            btnInputSelected = new Button();
            btnCopySelected = new Button();
            label7 = new Label();
            txtGameType = new TextBox();
            label2 = new Label();
            lvSubList = new ListView();
            colSubId = new ColumnHeader();
            colSubName = new ColumnHeader();
            colIsFree = new ColumnHeader();
            txtGameName = new TextBox();
            label6 = new Label();
            txtGameDesc = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtAppId = new TextBox();
            btnQueryAppDetail = new Button();
            tpPurchase = new TabPage();
            groupBox1 = new GroupBox();
            lvCartItems = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnClearCart = new Button();
            btnReloadCart = new Button();
            groupBox4 = new GroupBox();
            txtSubsOutput = new TextBox();
            btnPurchase = new Button();
            btnFakePurchase = new Button();
            groupBox2 = new GroupBox();
            txtSubsInput = new TextBox();
            btnImportCart = new Button();
            tpCmd = new TabPage();
            btnSendCmd = new Button();
            txtCmdRequest = new TextBox();
            txtCmdResponse = new TextBox();
            tpTodo = new TabPage();
            label3 = new Label();
            cbBotSelector = new ComboBox();
            btnReloadBots = new Button();
            tabControl.SuspendLayout();
            tpASFInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tpGameInfo.SuspendLayout();
            groupBox3.SuspendLayout();
            tpPurchase.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            tpCmd.SuspendLayout();
            SuspendLayout();
            // 
            // lvPlugins
            // 
            lvPlugins.Columns.AddRange(new ColumnHeader[] { colName, colVersion });
            lvPlugins.Dock = DockStyle.Fill;
            lvPlugins.FullRowSelect = true;
            lvPlugins.Location = new Point(0, 0);
            lvPlugins.Name = "lvPlugins";
            lvPlugins.Size = new Size(838, 267);
            lvPlugins.TabIndex = 4;
            lvPlugins.UseCompatibleStateImageBehavior = false;
            lvPlugins.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "插件名称";
            colName.Width = 200;
            // 
            // colVersion
            // 
            colVersion.Text = "插件版本";
            colVersion.Width = 100;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tpASFInfo);
            tabControl.Controls.Add(tpGameInfo);
            tabControl.Controls.Add(tpPurchase);
            tabControl.Controls.Add(tpCmd);
            tabControl.Controls.Add(tpTodo);
            tabControl.Location = new Point(3, 37);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(852, 747);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 2;
            // 
            // tpASFInfo
            // 
            tpASFInfo.Controls.Add(splitContainer1);
            tpASFInfo.Location = new Point(4, 26);
            tpASFInfo.Name = "tpASFInfo";
            tpASFInfo.Padding = new Padding(3);
            tpASFInfo.Size = new Size(844, 717);
            tpASFInfo.TabIndex = 0;
            tpASFInfo.Text = "ASF 信息";
            tpASFInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvBots);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvPlugins);
            splitContainer1.Size = new Size(838, 711);
            splitContainer1.SplitterDistance = 440;
            splitContainer1.TabIndex = 2;
            // 
            // lvBots
            // 
            lvBots.Columns.AddRange(new ColumnHeader[] { colBotName, colNickName, colStatus, colBalance, colCurrency, colSteamId });
            lvBots.Dock = DockStyle.Fill;
            lvBots.FullRowSelect = true;
            lvBots.Location = new Point(0, 0);
            lvBots.Name = "lvBots";
            lvBots.Size = new Size(838, 440);
            lvBots.TabIndex = 3;
            lvBots.UseCompatibleStateImageBehavior = false;
            lvBots.View = View.Details;
            // 
            // colBotName
            // 
            colBotName.Text = "机器人名称";
            colBotName.Width = 100;
            // 
            // colNickName
            // 
            colNickName.Text = "昵称";
            colNickName.Width = 100;
            // 
            // colStatus
            // 
            colStatus.Text = "状态";
            colStatus.Width = 100;
            // 
            // colBalance
            // 
            colBalance.Text = "余额 (小数点)";
            colBalance.Width = 100;
            // 
            // colCurrency
            // 
            colCurrency.Text = "货币";
            colCurrency.Width = 40;
            // 
            // colSteamId
            // 
            colSteamId.Text = "Steam Id";
            colSteamId.Width = 160;
            // 
            // tpGameInfo
            // 
            tpGameInfo.Controls.Add(btnInputSelected);
            tpGameInfo.Controls.Add(btnCopySelected);
            tpGameInfo.Controls.Add(label7);
            tpGameInfo.Controls.Add(txtGameType);
            tpGameInfo.Controls.Add(label2);
            tpGameInfo.Controls.Add(lvSubList);
            tpGameInfo.Controls.Add(txtGameName);
            tpGameInfo.Controls.Add(label6);
            tpGameInfo.Controls.Add(txtGameDesc);
            tpGameInfo.Controls.Add(label1);
            tpGameInfo.Controls.Add(groupBox3);
            tpGameInfo.Location = new Point(4, 26);
            tpGameInfo.Name = "tpGameInfo";
            tpGameInfo.Padding = new Padding(3);
            tpGameInfo.Size = new Size(844, 717);
            tpGameInfo.TabIndex = 4;
            tpGameInfo.Text = "获取游戏信息";
            // 
            // btnInputSelected
            // 
            btnInputSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInputSelected.Location = new Point(211, 572);
            btnInputSelected.Name = "btnInputSelected";
            btnInputSelected.Size = new Size(177, 32);
            btnInputSelected.TabIndex = 11;
            btnInputSelected.Text = "&E. 填入选中项";
            btnInputSelected.UseVisualStyleBackColor = true;
            btnInputSelected.Click += BtnInputSelected_Click;
            // 
            // btnCopySelected
            // 
            btnCopySelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCopySelected.Location = new Point(13, 572);
            btnCopySelected.Name = "btnCopySelected";
            btnCopySelected.Size = new Size(177, 32);
            btnCopySelected.TabIndex = 11;
            btnCopySelected.Text = "&C. 复制选中项";
            btnCopySelected.UseVisualStyleBackColor = true;
            btnCopySelected.Click += BtnCopySelected_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(79, 105);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 9;
            label7.Text = "双击填入";
            // 
            // txtGameType
            // 
            txtGameType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtGameType.Location = new Point(770, 6);
            txtGameType.Name = "txtGameType";
            txtGameType.PlaceholderText = "类型";
            txtGameType.ReadOnly = true;
            txtGameType.Size = new Size(58, 23);
            txtGameType.TabIndex = 8;
            txtGameType.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 4;
            label2.Text = "&Sub 信息";
            // 
            // lvSubList
            // 
            lvSubList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvSubList.CheckBoxes = true;
            lvSubList.Columns.AddRange(new ColumnHeader[] { colSubId, colSubName, colIsFree });
            lvSubList.FullRowSelect = true;
            lvSubList.Location = new Point(15, 125);
            lvSubList.Name = "lvSubList";
            lvSubList.Size = new Size(817, 441);
            lvSubList.TabIndex = 10;
            lvSubList.UseCompatibleStateImageBehavior = false;
            lvSubList.View = View.Details;
            lvSubList.DoubleClick += LvSubList_DoubleClick;
            // 
            // colSubId
            // 
            colSubId.Text = "Sub Id";
            colSubId.Width = 100;
            // 
            // colSubName
            // 
            colSubName.Text = "名称";
            colSubName.Width = 300;
            // 
            // colIsFree
            // 
            colIsFree.Text = "免费";
            colIsFree.Width = 40;
            // 
            // txtGameName
            // 
            txtGameName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGameName.Location = new Point(213, 6);
            txtGameName.Name = "txtGameName";
            txtGameName.PlaceholderText = "游戏名称";
            txtGameName.ReadOnly = true;
            txtGameName.Size = new Size(551, 23);
            txtGameName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 9);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 5;
            label6.Text = "名称";
            // 
            // txtGameDesc
            // 
            txtGameDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGameDesc.Location = new Point(213, 35);
            txtGameDesc.Multiline = true;
            txtGameDesc.Name = "txtGameDesc";
            txtGameDesc.PlaceholderText = "游戏简介";
            txtGameDesc.ReadOnly = true;
            txtGameDesc.Size = new Size(615, 58);
            txtGameDesc.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 37);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 5;
            label1.Text = "简介";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAppId);
            groupBox3.Controls.Add(btnQueryAppDetail);
            groupBox3.Location = new Point(9, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(153, 84);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "&AppId";
            // 
            // txtAppId
            // 
            txtAppId.ImeMode = ImeMode.Disable;
            txtAppId.Location = new Point(6, 22);
            txtAppId.MaxLength = 10;
            txtAppId.Name = "txtAppId";
            txtAppId.PlaceholderText = "单个游戏 AppId";
            txtAppId.Size = new Size(141, 23);
            txtAppId.TabIndex = 5;
            txtAppId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnQueryAppDetail
            // 
            btnQueryAppDetail.Location = new Point(6, 51);
            btnQueryAppDetail.Name = "btnQueryAppDetail";
            btnQueryAppDetail.Size = new Size(141, 28);
            btnQueryAppDetail.TabIndex = 6;
            btnQueryAppDetail.Text = "&Q. 查询信息";
            btnQueryAppDetail.UseVisualStyleBackColor = true;
            btnQueryAppDetail.Click += BtnQueryAppDetail_Click;
            // 
            // tpPurchase
            // 
            tpPurchase.Controls.Add(groupBox1);
            tpPurchase.Controls.Add(groupBox4);
            tpPurchase.Controls.Add(groupBox2);
            tpPurchase.Location = new Point(4, 26);
            tpPurchase.Name = "tpPurchase";
            tpPurchase.Padding = new Padding(3);
            tpPurchase.Size = new Size(844, 717);
            tpPurchase.TabIndex = 1;
            tpPurchase.Text = "购物功能";
            tpPurchase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(lvCartItems);
            groupBox1.Controls.Add(btnClearCart);
            groupBox1.Controls.Add(btnReloadCart);
            groupBox1.Location = new Point(5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(833, 217);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "购物车内容";
            // 
            // lvCartItems
            // 
            lvCartItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvCartItems.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvCartItems.FullRowSelect = true;
            lvCartItems.Location = new Point(138, 22);
            lvCartItems.Name = "lvCartItems";
            lvCartItems.Size = new Size(689, 189);
            lvCartItems.TabIndex = 11;
            lvCartItems.UseCompatibleStateImageBehavior = false;
            lvCartItems.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SubId / BundleId";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "名称";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "价格";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "私密购买";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "作为礼物";
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(7, 64);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(126, 36);
            btnClearCart.TabIndex = 12;
            btnClearCart.Text = "&C. 清空购物车";
            btnClearCart.UseVisualStyleBackColor = true;
            btnClearCart.Click += BtnClearCart_Click;
            // 
            // btnReloadCart
            // 
            btnReloadCart.Location = new Point(7, 22);
            btnReloadCart.Name = "btnReloadCart";
            btnReloadCart.Size = new Size(126, 36);
            btnReloadCart.TabIndex = 12;
            btnReloadCart.Text = "&G. 刷新购物车";
            btnReloadCart.UseVisualStyleBackColor = true;
            btnReloadCart.Click += BtnReloadCart_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtSubsOutput);
            groupBox4.Controls.Add(btnPurchase);
            groupBox4.Controls.Add(btnFakePurchase);
            groupBox4.Location = new Point(5, 505);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(833, 206);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "结算 | 卡单";
            // 
            // txtSubsOutput
            // 
            txtSubsOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubsOutput.Location = new Point(140, 22);
            txtSubsOutput.Multiline = true;
            txtSubsOutput.Name = "txtSubsOutput";
            txtSubsOutput.ReadOnly = true;
            txtSubsOutput.ScrollBars = ScrollBars.Vertical;
            txtSubsOutput.Size = new Size(687, 178);
            txtSubsOutput.TabIndex = 13;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(8, 22);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(126, 36);
            btnPurchase.TabIndex = 12;
            btnPurchase.Text = "&P. 为自己购买";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += BtnPurchase_Click;
            // 
            // btnFakePurchase
            // 
            btnFakePurchase.Location = new Point(8, 64);
            btnFakePurchase.Name = "btnFakePurchase";
            btnFakePurchase.Size = new Size(126, 36);
            btnFakePurchase.TabIndex = 12;
            btnFakePurchase.Text = "&F. 卡单";
            btnFakePurchase.UseVisualStyleBackColor = true;
            btnFakePurchase.Click += BtnFakePurchase_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtSubsInput);
            groupBox2.Controls.Add(btnImportCart);
            groupBox2.Location = new Point(5, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(833, 270);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "导入购物车";
            // 
            // txtSubsInput
            // 
            txtSubsInput.AcceptsReturn = true;
            txtSubsInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubsInput.Location = new Point(137, 22);
            txtSubsInput.Multiline = true;
            txtSubsInput.Name = "txtSubsInput";
            txtSubsInput.PlaceholderText = "一行一条, 前缀 s/123 = sub/123, b = bundle, 不写前缀默认 sub, 例如 54029";
            txtSubsInput.ScrollBars = ScrollBars.Vertical;
            txtSubsInput.Size = new Size(690, 239);
            txtSubsInput.TabIndex = 11;
            txtSubsInput.WordWrap = false;
            // 
            // btnImportCart
            // 
            btnImportCart.Location = new Point(6, 22);
            btnImportCart.Name = "btnImportCart";
            btnImportCart.Size = new Size(126, 36);
            btnImportCart.TabIndex = 12;
            btnImportCart.Text = "&I. 导入购物车";
            btnImportCart.UseVisualStyleBackColor = true;
            btnImportCart.Click += BtnImportCart_Click;
            // 
            // tpCmd
            // 
            tpCmd.Controls.Add(btnSendCmd);
            tpCmd.Controls.Add(txtCmdRequest);
            tpCmd.Controls.Add(txtCmdResponse);
            tpCmd.Location = new Point(4, 26);
            tpCmd.Name = "tpCmd";
            tpCmd.Padding = new Padding(3);
            tpCmd.Size = new Size(844, 717);
            tpCmd.TabIndex = 3;
            tpCmd.Text = "命令行";
            tpCmd.UseVisualStyleBackColor = true;
            // 
            // btnSendCmd
            // 
            btnSendCmd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSendCmd.Location = new Point(742, 688);
            btnSendCmd.Name = "btnSendCmd";
            btnSendCmd.Size = new Size(97, 23);
            btnSendCmd.TabIndex = 2;
            btnSendCmd.Text = "&S. 发送";
            btnSendCmd.UseVisualStyleBackColor = true;
            btnSendCmd.Click += BtnSendCmd_Click;
            // 
            // txtCmdRequest
            // 
            txtCmdRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCmdRequest.Location = new Point(7, 688);
            txtCmdRequest.Name = "txtCmdRequest";
            txtCmdRequest.Size = new Size(729, 23);
            txtCmdRequest.TabIndex = 1;
            txtCmdRequest.KeyPress += TxtCmdRequest_KeyPress;
            // 
            // txtCmdResponse
            // 
            txtCmdResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCmdResponse.Location = new Point(5, 6);
            txtCmdResponse.Multiline = true;
            txtCmdResponse.Name = "txtCmdResponse";
            txtCmdResponse.ReadOnly = true;
            txtCmdResponse.ScrollBars = ScrollBars.Vertical;
            txtCmdResponse.Size = new Size(833, 676);
            txtCmdResponse.TabIndex = 0;
            // 
            // tpTodo
            // 
            tpTodo.BackgroundImage = Properties.Resources.jntm;
            tpTodo.Location = new Point(4, 26);
            tpTodo.Name = "tpTodo";
            tpTodo.Padding = new Padding(3);
            tpTodo.Size = new Size(844, 717);
            tpTodo.TabIndex = 2;
            tpTodo.Text = "开发中……";
            tpTodo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 3;
            label3.Text = "&B. 选择机器人";
            // 
            // cbBotSelector
            // 
            cbBotSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBotSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBotSelector.FormattingEnabled = true;
            cbBotSelector.Location = new Point(96, 6);
            cbBotSelector.Name = "cbBotSelector";
            cbBotSelector.Size = new Size(675, 25);
            cbBotSelector.TabIndex = 0;
            // 
            // btnReloadBots
            // 
            btnReloadBots.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReloadBots.Location = new Point(776, 6);
            btnReloadBots.Name = "btnReloadBots";
            btnReloadBots.Size = new Size(75, 25);
            btnReloadBots.TabIndex = 1;
            btnReloadBots.Text = "&R. 刷新";
            btnReloadBots.UseVisualStyleBackColor = true;
            btnReloadBots.Click += BtnReloadBots_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 786);
            Controls.Add(btnReloadBots);
            Controls.Add(label3);
            Controls.Add(tabControl);
            Controls.Add(cbBotSelector);
            MinimumSize = new Size(600, 550);
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormClient_Load;
            tabControl.ResumeLayout(false);
            tpASFInfo.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tpGameInfo.ResumeLayout(false);
            tpGameInfo.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tpPurchase.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tpCmd.ResumeLayout(false);
            tpCmd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label2;
        private ListView lvSubList;
        private Button btnQueryAppDetail;
        private TextBox txtAppId;
        private Label label3;
        private ComboBox cbBotSelector;
        private ColumnHeader colBalance;
        private TextBox txtSubsInput;
        private TextBox txtSubsOutput;
        private Button btnImportCart;
        private ColumnHeader colCurrency;
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
        private TabPage tpCmd;
        private Button btnSendCmd;
        private TextBox txtCmdRequest;
        private TextBox txtCmdResponse;
        private TabPage tpGameInfo;
        private Button btnInputSelected;
        private Button btnCopySelected;
        private Label label7;
        private GroupBox groupBox1;
        private ListView lvCartItems;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnReloadCart;
        private Button btnClearCart;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private GroupBox groupBox4;
        private Button btnPurchase;
        private Button btnFakePurchase;
    }
}