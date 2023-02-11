namespace ASFEnhanceTools.Data
{
    internal sealed record AppDetailRequest
    {
        public List<uint> AppIds { get; set; } = new();
    }
}
