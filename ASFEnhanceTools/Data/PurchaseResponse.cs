namespace ASFEnhanceTools.Data
{
    internal sealed record PurchaseResponse : AbstractResponse<IDictionary<string, PurchaseResponse.ResultData>>
    {
        public sealed record ResultData
        {
            public AddCartResultData AddCartResult { get; set; } = new();
            public PurchaseResultData PurchaseResult { get; set; } = new();
        }

        public sealed record AddCartResultData
        {
            public Dictionary<string, bool> SubIds { get; set; } = new();
            public Dictionary<string, bool> BundleIds { get; set; } = new();
            public bool PurchaseForSelf { get; set; }
            public bool PurchaseAsGift { get; set; }
        }

        public sealed record PurchaseResultData
        {
            public List<CartItemData> CartItems { get; set; } = new();
            public bool Success { get; set; }
            public uint Cost { get; set; }
            public string Currency { get; set; } = "";
            public uint BalancePrev { get; set; }
            public uint BalanceNow { get; set; }
        }

        public sealed record CartItemData
        {
            public string Type { get; set; } = "";
            public uint Id { get; set; }
            public string Name { get; set; } = "";
        }
    }
}
