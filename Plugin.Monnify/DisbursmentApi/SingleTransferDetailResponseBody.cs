using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class SingleTransferDetailResponseBody
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
