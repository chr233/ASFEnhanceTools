using ASFEnhanceTools.Forms;
using ASFEnhanceTools.Properties;

namespace ASFEnhanceTools
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var config = GlobalConfig.Default;
            if (!config.Upgraded)
            {
                config.Upgrade();
                config.Upgraded = true;
                config.Save();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FormConnector());
        }
    }
}