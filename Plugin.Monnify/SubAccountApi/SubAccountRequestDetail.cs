
using Newtonsoft.Json;

namespace Plugin.Monnify.SubAccountApi
{
    public class SubAccountRequestDetail
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; } = "NGN";

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("defaultSplitPercentage")]
        public int DefaultSplitPercentage { get; set; }
    }

}
