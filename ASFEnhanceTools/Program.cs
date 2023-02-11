using ASFEnhanceTools.Forms;

namespace ASFEnhanceTools
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormConnector());
        }
    }
}