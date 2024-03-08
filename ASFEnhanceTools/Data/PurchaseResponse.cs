namespace ASFEnhanceTools.Data
{
    internal sealed record PurchaseResponse : AbstractResponse<IDictionary<string, PurchaseResponse.ResultData>>
    {
        public sealed record ResultData
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            public bool Success { get; set; }
            /// <summary>
            /// 花费
            /// </summary>
            public long Cost { get; set; }
            /// <summary>
            /// 货币
            /// </summary>
            public string? Currency { get; set; }
            /// <summary>
            /// 购物前余额
            /// </summary>
            public long BalancePrev { get; set; }
            /// <summary>
            /// 购物后余额
            /// </summary>
            public long BalanceNow { get; set; }
        }
    }
}
