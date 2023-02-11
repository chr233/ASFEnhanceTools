namespace ASFEnhanceTools.Data
{
    internal sealed record AppDetailResponse : AbstractResponse<IDictionary<string, IDictionary<string, AppDetailResponse.ResultData>>>
    {
        public sealed record ResultData
        {
            public bool Success { get; set; }
            public uint AppId { get; set; }
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public string Desc { get; set; } = "";
            public bool IsFree { get; set; }
            public bool Released { get; set; }
            public IEnumerable<SubData>? Subs { get; set; }
        }

        public sealed record SubData
        {
            public uint SubId { get; set; }
            public bool IsFree { get; set; }
            public string Name { get; set; } = "";

        }
    }
}
