namespace ASFEnhanceTools.Data;

public sealed record PluginResponse : AbstractResponse<IEnumerable<PluginResponse.ResultData>>
{
    public sealed record ResultData
    {
        public Dictionary<string, object>? Config { get; init; }
        public string Name { get; set; } = "";
        public string Version { get; set; } = "";
    }
}
