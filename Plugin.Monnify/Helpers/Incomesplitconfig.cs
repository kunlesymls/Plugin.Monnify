
using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public class Incomesplitconfig
    {
        [JsonProperty("subAccountCode")]
        public string SubAccountCode { get; set; }

        [JsonProperty("splitPercentage")]
        public decimal SplitPercentage { get; set; }

        [JsonProperty("feePercentage")]
        public decimal FeePercentage { get; set; }

        [JsonProperty("feeBearer")]
        public bool FeeBearer { get; set; }

        [JsonProperty("splitAmount")]
        public int SplitAmount { get; set; }


    }
}
