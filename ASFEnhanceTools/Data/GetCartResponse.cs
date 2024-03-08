using SteamKit2;

namespace ASFEnhanceTools.Data;
internal sealed record GetCartResponse : AbstractResponse<IDictionary<string, GetCartResponse.ResultData>>
{
    public sealed record ResultData
    {
        public List<CartItemData>? Items { get; set; }
    }

    public bool IsValid { get; set; }

    public sealed record CartItemData
    {
        public uint? PackageId { get; set; }
        public uint? BundleId { get; set; }
        public string? LineItemId { get; set; }
        public bool IsValid { get; set; }
        public ulong TimeAdded { get; set; }
        public string? PriceCents { get; set; }
        public ECurrencyCode CurrencyCode { get; set; }
        public string? PriceFormatted { get; set; }
        public bool IsGift { get; set; }
        public bool IsPrivate { get; set; }
        public GiftInfoData? GiftInfo { get; set; }
    }

    public sealed record GiftInfoData
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong AccountIdGiftee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GiftMessageData? GiftMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ulong TimeScheduledSend { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed record GiftMessageData
    {
        /// <summary>
        /// 
        /// </summary>
        public string? GifteeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Sentiment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Signature { get; set; }
    }
}
