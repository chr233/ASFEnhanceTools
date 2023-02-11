namespace ASFEnhanceTools.Data
{
    internal sealed record PurchaseRequest
    {
        public List<uint> SubIds { get; set; } = new();
        public List<uint> BundleIds { get; set; } = new();
        public bool SkipOwned { get; set; } = true;
    }
}
