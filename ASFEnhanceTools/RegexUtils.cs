using System.Text.RegularExpressions;

namespace ASFEnhanceTools;
internal static partial class RegexUtils
{
    [GeneratedRegex(@"(?:(s|sub|b|bundle)\/|)(\d+)", RegexOptions.IgnoreCase)]
    public static partial Regex MatchSubBundleId();


}
