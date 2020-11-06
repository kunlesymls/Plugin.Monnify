using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class GetBankAccountResponseBody
    {
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }
    }
}
