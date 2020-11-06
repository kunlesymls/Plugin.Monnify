using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class AccountDetail
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("amountPaid")]
        public string AmountPaid { get; set; }
    }


}
