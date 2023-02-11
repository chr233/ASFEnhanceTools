namespace ASFEnhanceTools.Data
{
    internal sealed record ASFResponse : AbstractResponse<ASFResponse.ResultData>
    {
        public sealed record ResultData
        {
            public string BuildVariant { get; set; } = "";
            public bool CanUpdate { get; set; }
            public Dictionary<string, object>? GlobalConfig { get; init; }
            public int MemoryUsage { get; set; }
            public DateTime ProcessStartTime { get; set; }
            public bool Service { get; set; }
            public string Version { get; set; } = "";
        }
    }
}
