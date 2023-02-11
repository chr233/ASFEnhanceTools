using ASFEnhanceTools.Data;
using ASFEnhanceTools.Extensions;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using BotData = ASFEnhanceTools.Data.BotResponse.ResultData;

namespace ASFEnhanceTools.Forms
{
    public partial class FormClient : Form
    {
        private HttpClient _httpClient { get; init; }

        private Dictionary<string, BotData> BotDataDict { get; init; } = new();

        private List<string> BotNames { get; init; } = new();

        private const int MaxTries = 3;

        public FormClient(Uri baseAddr, string passwd)
        {
            _httpClient = new() {
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
                    var responseASF = await _httpClient.SendToObj<ASFResponse>(requestASF);

                    if (responseASF != null && responseASF.Success && responseASF.Result != null)
                    {
                        Text = string.Format("Url: {0} - ASF: {1} {2}", _httpClient.BaseAddress, responseASF.Result.Version, responseASF.Result.BuildVariant);
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception("连接至 ASF 失败");
                }
                flag = false;

                for (int i = 0; i < MaxTries; i++)
                {
                    using var requestPlugins = new HttpRequestMessage(HttpMethod.Get, "/Api/Plugins");
                    var responsePlugins = await _httpClient.SendToObj<PluginResponse>(requestPlugins);

                    if (responsePlugins != null && responsePlugins.Success && responsePlugins.Result != null)
                    {
                        lvPlugins.BeginUpdate();
                        foreach (var plugin in responsePlugins.Result)
                        {
                            lvPlugins.Items.Add(new ListViewItem {
                                Text = plugin.Name,
                                SubItems = { plugin.Version },
                            });

                            if (plugin.Name == "ASFEnhance")
                            {
                                Text += string.Format(" ASFEnhance: {0}", plugin.Version);
                            }
                        }
                        lvPlugins.EndUpdate();

                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    throw new Exception("连接至 ASF 失败");
                }
                flag = false;

                for (int i = 0; i < MaxTries; i++)
                {
                    using var requestBots = new HttpRequestMessage(HttpMethod.Get, "/Api/Bot/ASF");
                    var responseBots = await _httpClient.SendToObj<BotResponse>(requestBots);

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

                            string nickname = bot.IsConnectedAndLoggedOn ? bot.Nickname : "未知";
                            string balance = bot.IsConnectedAndLoggedOn ? bot.WalletBalance.ToString() : "---";
                            string currency = bot.IsConnectedAndLoggedOn ? bot.WalletCurrency.ToString() : "---";

                            lvBots.Items.Add(new ListViewItem {
                                Text = bot.BotName,
                                SubItems = {
                                    nickname,
                                    bot.IsConnectedAndLoggedOn ? "在线" :"离线",
                                    balance,
                                    currency,
                                    bot.SteamID.ToString(),
                                }
                            });

                            cbBotSelector.Items.Add(string.Format("机器人: {0} 昵称: {1} 余额: {2} {3} SteamId: {4}", bot.BotName, nickname, balance, currency, bot.SteamID));
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
                    throw new Exception("连接至 ASF 失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("出现意外错误：{0}", ex.Message));
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

        private async void btnQueryAppDetail_Click(object sender, EventArgs e)
        {
            try
            {
                btnQueryAppDetail.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show("未选择机器人");
                    return;
                }

                if (uint.TryParse(txtAppId.Text, out uint appId))
                {
                    for (int i = 0; i < MaxTries; i++)
                    {
                        var payload = new AppDetailRequest {
                            AppIds = { appId },
                        };

                        using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/ASFEnhance/{bot.BotName}/GetAppDetail") {
                            Content = JsonContent.Create(payload)
                        };
                        var response = await _httpClient.SendToObj<AppDetailResponse>(request);

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
                                            lvSubList.Items.Add(new ListViewItem() {
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
                                    txtGameName.Text = "读取失败";
                                    txtGameDesc.Text = "AppId 不存在 / 机器人可能离线";
                                    txtGameType.Text = "";
                                }
                            }
                            else
                            {
                                txtGameName.Text = "读取失败";
                                txtGameDesc.Text = "找不到机器人";
                                txtGameType.Text = "";
                            }
                            return;
                        }
                    }
                    MessageBox.Show("连接至 ASF 失败");
                }
                else
                {
                    MessageBox.Show("AppId 无效! 请输入整数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAppId.Focus();
                }
            }
            finally
            {
                btnQueryAppDetail.Enabled = true;
            }
        }

        private void lvSubList_DoubleClick(object sender, EventArgs e)
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

        private async void btnReloadBots_Click(object sender, EventArgs e)
        {
            try
            {
                btnReloadBots.Enabled = false;
                for (int i = 0; i < MaxTries; i++)
                {
                    using var request = new HttpRequestMessage(HttpMethod.Get, "/Api/Bot/ASF");
                    var response = await _httpClient.SendToObj<BotResponse>(request);

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

                            lvBots.Items.Add(new ListViewItem {
                                Text = bot.BotName,
                                SubItems = {
                                    nickname,
                                    bot.IsConnectedAndLoggedOn ? "在线" :"离线",
                                    balance,
                                    currency,
                                    bot.SteamID.ToString(),
                                }
                            });

                            cbBotSelector.Items.Add(string.Format("机器人: {0} 昵称: {1} 余额: {2} {3} SteamId: {4}", bot.BotName, nickname, balance, currency, bot.SteamID));
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
                MessageBox.Show("连接至 ASF 失败");
            }
            finally
            {
                btnReloadBots.Enabled = true;
            }
        }

        private async void btnPurchase_Click(object sender, EventArgs e)
        {
            List<uint> subIds = new();
            List<uint> bundles = new();

            Regex matchIds = new(@"(?:(s|sub|b|bundle)\/|)(\d+)", RegexOptions.IgnoreCase);

            foreach (var line in txtSubsInput.Lines)
            {
                var match = matchIds.Match(line);
                if (match.Success)
                {
                    var type = match.Groups[1].Value;
                    var strId = match.Groups[2].Value;

                    if (uint.TryParse(strId, out uint id))
                    {
                        switch (type.ToLowerInvariant())
                        {
                            case "b":
                            case "bundle":
                                bundles.Add(id);
                                break;
                            default:
                            case "s":
                            case "sub":
                                subIds.Add(id);
                                break;
                        }
                    }
                }
            }

            if (subIds.Count + bundles.Count == 0)
            {
                MessageBox.Show("没有有效的 SubId / BundleId, 请检查输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubsInput.Focus();
                return;
            }

            try
            {
                btnQueryAppDetail.Enabled = false;
                var bot = FetchBot(cbBotSelector.SelectedIndex);

                if (bot == null)
                {
                    MessageBox.Show("未选择机器人");
                    return;
                }

                if (uint.TryParse(txtAppId.Text, out uint appId))
                {
                    for (int i = 0; i < MaxTries; i++)
                    {
                        var payload = new PurchaseRequest {
                            SubIds = subIds,
                            BundleIds = bundles,
                            SkipOwned = true,
                        };

                        using var request = new HttpRequestMessage(HttpMethod.Post, $"/Api/ASFEnhance/{bot.BotName}/Purchase") {
                            Content = JsonContent.Create(payload)
                        };
                        var response = await _httpClient.SendToObj<PurchaseResponse>(request);

                        if (response != null && response.Success && response.Result != null)
                        {
                            StringBuilder sb = new();

                            if (response.Result.TryGetValue(bot.BotName, out var result))
                            {
                                var pResult = result.PurchaseResult;
                                sb.AppendLine(string.Format("购买结果: {0} 余额变动: {1} -> {2} ({3})", pResult.Success ? "成功" : "失败", pResult.BalancePrev, pResult.BalanceNow, pResult.Currency));
                                sb.AppendLine(string.Format("购物车总价: {0} ({1}), 购物车内容:", pResult.Cost, pResult.Currency));
                                int j = 1;
                                foreach (var item in pResult.CartItems)
                                {
                                    sb.AppendLine(string.Format(" {0}: {1}/{2} {3}", j++, item.Type, item.Id, item.Name));
                                }
                            }
                            else
                            {
                                sb.AppendLine("找不到机器人");
                            }

                            txtSubsOutput.Text = sb.ToString();
                            return;
                        }
                    }
                    MessageBox.Show("连接至 ASF 失败");
                }
                else
                {
                    MessageBox.Show("AppId 无效! 请输入整数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAppId.Focus();
                }
            }
            finally
            {
                btnQueryAppDetail.Enabled = true;
            }
        }
    }
}
