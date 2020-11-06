using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class TransactionResponse
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("amountPaid")]
        public string AmountPaid { get; set; }

        [JsonProperty("totalPayable")]
        public string TotalPayable { get; set; }

        [JsonProperty("paidOn")]
        public string PaidOn { get; set; }

        [JsonProperty("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }
    }

}
