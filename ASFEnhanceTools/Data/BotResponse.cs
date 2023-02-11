using SteamKit2;

namespace ASFEnhanceTools.Data
{
    internal sealed record BotResponse : AbstractResponse<IDictionary<string, BotResponse.ResultData>>
    {
        public sealed record ResultData
        {
            public string BotName { get; set; } = "";
            public bool IsConnectedAndLoggedOn { get; set; }
            public bool KeepRunning { get; set; }
            public string Nickname { get; set; } = "";
            public long SteamID { get; set; }
            public int WalletBalance { get; set; }
            public ECurrencyCode WalletCurrency { get; set; } = ECurrencyCode.Invalid;
        }
    }
}
