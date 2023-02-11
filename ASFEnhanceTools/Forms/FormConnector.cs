using ASFEnhanceTools.Data;
using ASFEnhanceTools.Extensions;
using System.Diagnostics;
using System.Reflection;

namespace ASFEnhanceTools.Forms
{
    public partial class FormConnector : Form
    {
        private HttpClient _httpClient { get; set; } = new();

        public FormConnector()
        {
            InitializeComponent();
        }

        private static void OpenLink(string uri)
        {
            Process.Start(new ProcessStartInfo(uri) { UseShellExecute = true });
        }

        private void btnCheckASFEToolsUpdate_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFEnhance";
            OpenLink(target);
        }

        private void btnGetASFEnhance_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFEnhance";
            OpenLink(target);
        }
        private void tsLblGitHub_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233";
            OpenLink(target);
        }

        private void btnAfadian_Click(object sender, EventArgs e)
        {
            OpenLink("https://afdian.net/a/chr233");
        }

        private void FormConnector_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version("0");
            tsLblVersion.Text = version.ToString();
#if DEBUG
            txtAddress.Text = "http://localhost:1500";
#else
            txtAddress.Text = "http://localhost:1242";
#endif
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                btnTestConnection.Enabled = false;
                string addr = txtAddress.Text;
                string passwd = txtPassword.Text;
                if (!string.IsNullOrEmpty(addr) && Uri.TryCreate(addr, UriKind.RelativeOrAbsolute, out var uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    _httpClient = new() {
                        BaseAddress = uriResult,
                        DefaultRequestHeaders =
                        {
                            { "accept","application/json" },
                            { "Authentication", passwd },
                        }
                    };

                    try
                    {
                        var requestPlugin = new HttpRequestMessage(HttpMethod.Get, "/Api/Plugins");
                        var responsePlugin = await _httpClient.SendToObj<PluginResponse>(requestPlugin);

                        if (responsePlugin != null && responsePlugin.Success)
                        {
                            if ((responsePlugin.Result != null) && responsePlugin.Result.Any(x => x.Name == "ASFEnhance"))
                            {
                                using var form = new FormClient(uriResult, passwd);
                                Hide();
                                form.ShowDialog();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("尚未安装 ASFEnhance 插件，请先安装 ASFEnhance 插件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("连接失败, 请检查地址和密码是否填写正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAddress.Focus();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("连接出错：{0}", ex.Message), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ASF API地址无效", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
            }
            finally
            {
                btnTestConnection.Enabled = true;
            }
        }

        private void tsLblGitHub_MouseEnter(object sender, EventArgs e)
        {
            tsLblGitHub.Text = "点个星星秋梨膏";
        }

        private void tsLblGitHub_MouseLeave(object sender, EventArgs e)
        {
            tsLblGitHub.Text = "GitHub";
        }
    }
}
