using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class SettlementNotification
    {
        [JsonProperty("settlementReference")]
        public string SettlementReference { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string DestinationAccountNumber { get; set; }

        [JsonProperty("destinationAccountName")]
        public string DestinationAccountName { get; set; }

        [JsonProperty("destinationBankCode")]
        public string DestinationBankCode { get; set; }

        [JsonProperty("destinationBankName")]
        public string DestinationBankName { get; set; }

        [JsonProperty("settlementTime")]
        public string SettlementTime { get; set; }

        [JsonProperty("transactionsCount")]
        public int TransactionsCount { get; set; }
    }

}
