
using Newtonsoft.Json;

namespace Plugin.Monnify.SubAccountApi
{
    public class EditSubAccountRequest
    {
        [JsonProperty("subAccountCode")]
        public string SubAccountCode { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

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
