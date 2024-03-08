using ASFEnhanceTools.Data;
using ASFEnhanceTools.Extensions;
using ASFEnhanceTools.Properties;
using System.Diagnostics;
using System.Reflection;

namespace ASFEnhanceTools.Forms
{
    public partial class FormConnector : Form
    {
        private HttpClient HttpClient { get; set; } = new();

        public FormConnector()
        {
            InitializeComponent();
        }

        private static void OpenLink(string uri)
        {
            Process.Start(new ProcessStartInfo(uri) { UseShellExecute = true });
        }

        private void BtnCheckASFEToolsUpdate_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFEnhanceTools/releases";
            OpenLink(target);
        }

        private void BtnGetASFEnhance_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233/ASFEnhance";
            OpenLink(target);
        }
        private void TsLblGitHub_Click(object sender, EventArgs e)
        {
            const string target = "https://github.com/chr233";
            OpenLink(target);
        }

        private void BtnAfadian_Click(object sender, EventArgs e)
        {
            const string target = "https://afdian.net/a/chr233";
            OpenLink(target);
        }

        private void BtnSteam_Click(object sender, EventArgs e)
        {
            const string target = "https://steamcommunity.com/id/Chr_/";
            OpenLink(target);
        }

        private void FormConnector_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version("0.0.0.0");
            tsLblVersion.Text = version.ToString();

            txtAddress.Text = GlobalConfig.Default.IPCAddress;
            txtPassword.Text = GlobalConfig.Default.IPCPassword;
            chkSavePasswd.Checked = GlobalConfig.Default.SavePassword;
        }

        private void FormConnector_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalConfig.Default.IPCAddress = txtAddress.Text;
            GlobalConfig.Default.IPCPassword = chkSavePasswd.Checked ? txtPassword.Text : "";
            GlobalConfig.Default.SavePassword = chkSavePasswd.Checked;
            GlobalConfig.Default.Save();
        }

        private async void BtnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                btnTestConnection.Enabled = false;
                string addr = txtAddress.Text;
                string passwd = txtPassword.Text;
                if (!string.IsNullOrEmpty(addr) && Uri.TryCreate(addr, UriKind.RelativeOrAbsolute, out var uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    HttpClient = new()
                    {
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
                        var responsePlugin = await HttpClient.SendToObj<PluginResponse>(requestPlugin);

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
                                MessageBox.Show(Langs.ASFEnhanceNotInstalled, Langs.Tips, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show(Langs.ConnectFailed, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAddress.Focus();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format(Langs.ConnectError, ex.Message), Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Langs.IPCAddressInvalid, Langs.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
            }
            finally
            {
                btnTestConnection.Enabled = true;
            }
        }


    }
}
