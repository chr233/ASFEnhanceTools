using ASFEnhanceTools.Data;
using ASFEnhanceTools.Extensions;

using System.Net.Http.Json;
using System.Reflection;
using System.Text;

using BotData = ASFEnhanceTools.Data.BotResponse.ResultData;

namespace ASFEnhanceTools.Forms
{
    public partial class FormClient : Form
    {
        private HttpClient HttpClient { get; init; }

        private Dictionary<string, BotData> BotDataDict { get; init; } = new();

        private List<string> BotNames { get; init; } = new();

        private const int MaxTries = 3;

        public FormClient(Uri baseAddr, string passwd)
        {
#if DEBUG
            // 创建 HttpClientHandler 对象并设置代理
            var handler = new HttpClientHandler
            {
                //Proxy = new WebProxy("http://10.10.0.21:8080"),
                //UseProxy = true
            };
#else
            var handler = new HttpClientHandler();
#endif

            HttpClient = new(handler)
            {
                BaseAddress = baseAddr,
                DefaultRequestHeaders =
                        {
                            { "accept","application/json" },
                            { "Authentication", passwd },
                        }
            };

            InitializeComponent();
        }

        private async void FormClient_Load(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                for (int i = 0; i < MaxTries; i++)
                {
                    using var requestASF = new HttpRequestMessage(HttpMethod.Get, "/Api/ASF");
                    var responseASF = await HttpClient.SendToObj<ASFResponse>(requestASF);

                    if (responseASF != null && responseASF.Success && responseASF.Result != null)
                    {
                        Text = string.Format("ASF: {0}", responseASF.Result.Version);
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception(Langs.ConnectToASFFailed);
                }
                flag = false;

                for (int i = 0; i < MaxTries; i++)
                {
                    using var requestPlugins = new HttpRequestMessage(HttpMethod.Get, "/Api/Plugins");
                    var responsePlugins = await HttpClient.SendToObj<PluginResponse>(requestPlugins);

                    if (responsePlugins != null && responsePlugins.Success && responsePlugins.Result != null)
                    {
                        lvPlugins.BeginUpdate();
                        foreach (var plugin in responsePlugins.Result)
                        {
                            lvPlugins.Items.Add(new ListViewItem
                            {
                                Text = plugin.Name,
                                SubItems = { plugin.Version },
                            });

                            if (plugin.Name == "ASFEnhance")
                            {
                                var version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version("0");
                                Text += string.Format(" - ASFE: {0} - ASFET: {1}", plugin.Version, version);
                            }
                        }
                        lvPlugins.EndUpdate();

                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception(Langs.ConnectToASFFailed);
                }
                flag = false;

                for (int i = 0; i < MaxTries; i++)
                {
                    using var requestBots = new HttpRequestMessage(HttpMethod.Get, "/Api/Bot/ASF");
                    var responseBots = await HttpClient.SendToObj<BotResponse>(requestBots);

                    if (responseBots != null && responseBots.Success && responseBots.Result != null)
                    {
                        lvBots.BeginUpdate();
                        cbBotSelector.BeginUpdate();

                        BotNames.Clear();
                        BotDataDict.Clear();

                        foreach (var (botName, bot) in responseBots.Result)
                        {
                            BotNames.Add(bot.BotName);
                            BotDataDict.Add(bot.BotName, bot);

                            string nickname = bot.IsConnectedAndLoggedOn ? bot.Nickname : Langs.Unknown;
                            string balance = bot.IsConnectedAndLoggedOn ? bot.WalletBalance.ToString() : "---";
                            string currency = bot.IsConnectedAndLoggedOn ? bot.WalletCurrency.ToString() : "---";

                            lvBots.Items.Add(new ListViewItem
                            {
                                Text = bot.BotName,
                                SubItems = {
                                    nickname,
                                    bot.IsConnectedAndLoggedOn ? Langs.Online :Langs.Offline,
                                    balance,
                                    currency,
                                    bot.SteamID.ToString(),
                                }
                            });

                            cbBotSelector.Items.Add(string.Format(Langs.BotListTemplete, bot.BotName, nickname, balance, currency, bot.SteamID));
                        }

                        if (cbBotSelector.Items.Count > 0)
                        {
                            cbBotSelector.SelectedIndex = 0;
                        }

                        lvBots.EndUpdate();
                        cbBotSelector.EndUpdate();

                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception(Langs.ConnectToASFFailed);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Langs.ConnectErrorUnexpectedly, ex.Message));
            }
        }

        private BotData? FetchBot(int index)
        {
            string? botName = null;
            if (index >= 0 && index < BotNames.Count)
            {
                botName = BotNames[index];
            }

            if (!string.IsNullOrEmpty(botName) && BotDataDict.TryGetValue(botName, out var bot))
            {
                return bot;
            }
            else
            {
                return null;
            }
        }

        private async void BtnQueryAppDetail_Click(object sender, EventArgs e)
        {
            try
            {
                btnQueryAppDetail.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show(Langs.NoBotSelected);
                    return;
                }

                if (uint.TryParse(txtAppId.Text, out uint appId))
                {
                    for (int i = 0; i < MaxTries; i++)
                    {
                        var payload = new AppDetailRequest
                        {
                            AppIds = { appId },
                        };

                        using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/Purchase/GetAppDetail/{bot.BotName}")
                        {
                            Content = JsonContent.Create(payload)
                        };
                        var response = await HttpClient.SendToObj<AppDetailResponse>(request);

                        if (response != null && response.Success && response.Result != null)
                        {
                            lvSubList.Items.Clear();

                            if (response.Result.TryGetValue(bot.BotName, out var dic) &&
                                dic.TryGetValue(appId.ToString(), out var detail))
                            {
                                if (detail.Success)
                                {
                                    txtGameName.Text = detail.Name;
                                    txtGameDesc.Text = detail.Desc;
                                    txtGameType.Text = detail.Type.ToUpperInvariant();

                                    if (detail.Subs != null)
                                    {
                                        lvSubList.BeginUpdate();
                                        foreach (var sub in detail.Subs)
                                        {
                                            lvSubList.Items.Add(new ListViewItem()
                                            {
                                                Text = sub.SubId.ToString(),
                                                Tag = string.Format("sub/{0} #{1}", sub.SubId, sub.Name),
                                                SubItems =
                                            {
                                                    sub.Name,
                                                    sub.IsFree ? "√" :"×"
                                                }
                                            });
                                        }
                                        lvSubList.EndUpdate();
                                    }
                                }
                                else
                                {
                                    txtGameName.Text = Langs.ReadFailed;
                                    txtGameDesc.Text = Langs.AppIdNotExistsOrBotOffline;
                                    txtGameType.Text = "";
                                }
                            }
                            else
                            {
                                txtGameName.Text = Langs.ReadFailed;
                                txtGameDesc.Text = Langs.botNotFound;
                                txtGameType.Text = "";
                            }
                            return;
                        }
                    }
                    MessageBox.Show(Langs.ConnectToASFFailed);
                }
                else
                {
                    MessageBox.Show(Langs.AppIdIsInvalid, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAppId.Focus();
                }
            }
            finally
            {
                btnQueryAppDetail.Enabled = true;
            }
        }

        private void LvSubList_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSubList.SelectedItems)
            {
                string? payload = item.Tag as string;
                if (!string.IsNullOrEmpty(payload))
                {
                    txtSubsInput.Text = (txtSubsInput.Text.Trim() + "\r\n" + payload).Trim();
                }
            }
        }

        private async void BtnReloadBots_Click(object sender, EventArgs e)
        {
            try
            {
                btnReloadBots.Enabled = false;
                for (int i = 0; i < MaxTries; i++)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Get, "/Api/Bot/ASF");
                    var response = await HttpClient.SendToObj<BotResponse>(request);

                    if (response != null && response.Success && response.Result != null)
                    {
                        lvBots.Items.Clear();
                        cbBotSelector.Items.Clear();

                        lvBots.BeginUpdate();
                        cbBotSelector.BeginUpdate();

                        BotNames.Clear();
                        BotDataDict.Clear();

                        foreach (var (botName, bot) in response.Result)
                        {
                            BotNames.Add(bot.BotName);
                            BotDataDict.Add(bot.BotName, bot);

                            string nickname = bot.IsConnectedAndLoggedOn ? bot.Nickname : "未知";
                            string balance = bot.IsConnectedAndLoggedOn ? bot.WalletBalance.ToString() : "---";
                            string currency = bot.IsConnectedAndLoggedOn ? bot.WalletCurrency.ToString() : "---";

                            lvBots.Items.Add(new ListViewItem
                            {
                                Text = bot.BotName,
                                SubItems = {
                                    nickname,
                                    bot.IsConnectedAndLoggedOn ? Langs.Online :Langs.Offline,
                                    balance,
                                    currency,
                                    bot.SteamID.ToString(),
                                }
                            });

                            cbBotSelector.Items.Add(string.Format(Langs.BotListTemplete, bot.BotName, nickname, balance, currency, bot.SteamID));
                        }

                        if (cbBotSelector.Items.Count > 0)
                        {
                            cbBotSelector.SelectedIndex = 0;
                        }

                        lvBots.EndUpdate();
                        cbBotSelector.EndUpdate();
                        return;
                    }
                }
                MessageBox.Show(Langs.ConnectToASFFailed);
            }
            finally
            {
                btnReloadBots.Enabled = true;
            }
        }

        private async Task DoPurchase(bool fakePurchase)
        {
            var bot = FetchBot(cbBotSelector.SelectedIndex);

            if (bot == null)
            {
                MessageBox.Show(Langs.NoBotSelected);
                return;
            }
            for (int i = 0; i < MaxTries; i++)
            {
                using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/Purchase/Purchase/{bot.BotName}")
                {
                    Content = JsonContent.Create(new PurchaseRequest { FakePurchase = fakePurchase })
                };
                var response = await HttpClient.SendToObj<PurchaseResponse>(request);

                if (response != null && response.Success && response.Result != null)
                {
                    StringBuilder sb = new();

                    if (response.Result.TryGetValue(bot.BotName, out var result) && result != null)
                    {
                        sb.AppendLine(string.Format("结算结果: {0}", result.Success ? Langs.Success : Langs.Failed));
                        sb.AppendLine(string.Format("花费: {0} {1}", result.Cost, result.Currency));
                        sb.AppendLine(string.Format("购物前余额: {0} {1}", result.BalancePrev, result.Currency));
                        sb.AppendLine(string.Format("购物后余额: {0} {1}", result.BalanceNow, result.Currency));
                    }
                    else
                    {
                        sb.AppendLine(Langs.botNotFound);
                    }

                    txtSubsOutput.Text = sb.ToString();
                    return;
                }
            }
            MessageBox.Show(Langs.ConnectToASFFailed);

        }

        private void TxtCmdRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnSendCmd_Click(sender, e);
            }
        }

        private async void BtnSendCmd_Click(object sender, EventArgs e)
        {
            string cmd = txtCmdRequest.Text.Trim();

            if (string.IsNullOrEmpty(cmd))
            {
                return;
            }

            try
            {
                btnSendCmd.Enabled = false;

                for (int i = 0; i < MaxTries; i++)
                {
                    var payload = new CommandRequest
                    {
                        Command = cmd,
                    };

                    if (!string.IsNullOrEmpty(txtCmdResponse.Text))
                    {
                        txtCmdResponse.Text += "\r\n\r\n";
                    }
                    txtCmdResponse.Text += DateTime.Now.ToLocalTime() + "\r\n" + cmd + "\r\n";

                    using var request = new HttpRequestMessage(HttpMethod.Post, "/Api/Command")
                    {
                        Content = JsonContent.Create(payload)
                    };
                    var response = await HttpClient.SendToObj<CommandResponse>(request);

                    if (response != null && response.Success && response.Result != null)
                    {
                        txtCmdResponse.Text += DateTime.Now.ToLocalTime() + "\r\n";
                        txtCmdResponse.Text += response.Result;
                        txtCmdRequest.Clear();
                        txtCmdRequest.Focus();
                        return;
                    }
                }
                MessageBox.Show(Langs.ConnectToASFFailed);
            }
            finally
            {
                btnSendCmd.Enabled = true;
            }
        }

        private void BtnCopySelected_Click(object sender, EventArgs e)
        {
            List<string> data = [];
            foreach (ListViewItem item in lvSubList.CheckedItems)
            {
                string? payload = item.Tag as string;
                if (!string.IsNullOrEmpty(payload))
                {
                    data.Add((payload).Trim());
                }
            }

            if (data.Count == 0)
            {
                MessageBox.Show(Langs.NotSelectedAntthing, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                lvSubList.Focus();
            }
            else
            {
                Clipboard.SetText(string.Join("\r\n", data));
            }
        }

        private void BtnInputSelected_Click(object sender, EventArgs e)
        {
            List<string> data = [];
            foreach (ListViewItem item in lvSubList.CheckedItems)
            {
                string? payload = item.Tag as string;
                if (!string.IsNullOrEmpty(payload))
                {
                    data.Add((payload).Trim());
                }
            }

            if (data.Count == 0)
            {
                MessageBox.Show(Langs.NotSelectedAntthing, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                lvSubList.Focus();
            }
            else
            {
                txtSubsInput.Text = (txtSubsInput.Text.Trim() + "\r\n" + string.Join("\r\n", data)).Trim();
                tabControl.SelectedIndex = 2;
            }
        }

        private async void BtnReloadCart_Click(object sender, EventArgs e)
        {
            try
            {
                btnReloadCart.Enabled = false;
                btnFakePurchase.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show(Langs.NoBotSelected);
                    return;
                }

                for (int i = 0; i < MaxTries; i++)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/Purchase/GetCart/{bot.BotName}");
                    var response = await HttpClient.SendToObj<GetCartResponse>(request);

                    if (response != null && response.Success && response.Result != null)
                    {
                        if (response.Result.TryGetValue(bot.BotName, out var data))
                        {
                            lvCartItems.BeginUpdate();
                            lvCartItems.Items.Clear();

                            if (data.Items != null)
                            {
                                foreach (var item in data.Items)
                                {
                                    var id = (item.BundleId > 0 ? $"bundle/{item.BundleId}" : $"sub{item.PackageId}") ?? "??";
                                    lvCartItems.Items.Add(new ListViewItem
                                    {
                                        Text = item.LineItemId,
                                        Tag = item,
                                        SubItems =
                                        {
                                            id,
                                            item.Name,
                                            item.PriceFormatted,
                                            item.IsPrivate ? "√" : "×",
                                            item.IsGift ? "√" : "×",
                                        }
                                    });
                                }
                            }

                            lvCartItems.EndUpdate();
                        }
                        else
                        {
                            MessageBox.Show(Langs.LoadCartFailed, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show(Langs.ConnectToASFFailed);
            }
            finally
            {
                btnReloadCart.Enabled = true;
                btnFakePurchase.Enabled = true;
            }
        }

        private async void BtnClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                btnClearCart.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show(Langs.NoBotSelected);
                    return;
                }

                for (int i = 0; i < MaxTries; i++)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/Purchase/ClearCart/{bot.BotName}");
                    var response = await HttpClient.SendToObj<ClearCartResponse>(request);

                    if (response != null && response.Success && response.Result != null)
                    {
                        if (response.Result.TryGetValue(bot.BotName, out var success))
                        {
                            lvCartItems.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("清空购物车失败", Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show(Langs.ConnectToASFFailed);
            }
            finally
            {
                btnClearCart.Enabled = true;
            }
        }

        private async void BtnImportCart_Click(object sender, EventArgs e)
        {
            try
            {
                btnImportCart.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show(Langs.NoBotSelected);
                    return;
                }

                List<AddCartRequest.ItemData> items = [];
                var matchIds = RegexUtils.MatchSubBundleId();
                foreach (var line in txtSubsInput.Lines)
                {
                    var match = matchIds.Match(line);
                    if (match.Success)
                    {
                        var type = match.Groups[1].Value;
                        var strId = match.Groups[2].Value;

                        var item = new AddCartRequest.ItemData
                        {
                            IsGift = false,
                            IsPrivate = false,
                            GiftInfo = null,
                        };

                        if (uint.TryParse(strId, out uint id))
                        {
                            switch (type.ToLowerInvariant())
                            {
                                case "b":
                                case "bundle":
                                    item.BundleId = id;
                                    break;
                                default:
                                case "s":
                                case "sub":
                                    item.PackageId = id;
                                    break;
                            }

                            items.Add(item);
                        }
                    }
                }

                if (items.Count == 0)
                {
                    MessageBox.Show(Langs.NoValidSubIdsOrBundleIds, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < MaxTries; i++)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/Purchase/AddCart/{bot.BotName}")
                    {
                        Content = JsonContent.Create(new AddCartRequest { Items = items }),
                    };
                    var response = await HttpClient.SendToObj<GetCartResponse>(request);

                    if (response != null && response.Success && response.Result != null)
                    {
                        if (response.Result.TryGetValue(bot.BotName, out var data))
                        {
                            lvCartItems.BeginUpdate();
                            lvCartItems.Items.Clear();

                            if (data.Items != null)
                            {
                                foreach (var item in data.Items)
                                {
                                    var id = (item.BundleId > 0 ? $"bundle/{item.BundleId}" : $"sub{item.PackageId}") ?? "??";
                                    lvCartItems.Items.Add(new ListViewItem
                                    {
                                        Text = id,
                                        Tag = item,
                                        SubItems =
                                        {
                                            item.LineItemId,
                                            item.PriceFormatted,
                                            item.IsPrivate ? "√" : "×",
                                            item.IsGift ? "√" : "×",
                                        }
                                    });
                                }
                            }

                            lvCartItems.EndUpdate();
                        }
                        else
                        {
                            MessageBox.Show(Langs.LoadCartFailed, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show(Langs.ConnectToASFFailed);
            }
            finally
            {
                btnImportCart.Enabled = true;
            }
        }

        private async void BtnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                btnPurchase.Enabled = false;
                await DoPurchase(false);
            }
            finally
            {
                btnPurchase.Enabled = true;
            }
        }

        private async void BtnFakePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                btnPurchase.Enabled = false;
                await DoPurchase(true);
            }
            finally
            {
                btnPurchase.Enabled = true;
            }
        }
    }
}
