using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class TransactionNotification
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("amountPaid")]
        public string AmountPaid { get; set; }

        [JsonProperty("totalPayable")]
        public string TotalPayable { get; set; }

        [JsonProperty("settlementAmount")]
        public string SettlementAmount { get; set; }

        [JsonProperty("paidOn")]
        public string PaidOn { get; set; }

        [JsonProperty("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("accountDetails")]
        public AccountDetail AccountDetails { get; set; }

        [JsonProperty("cardDetails")]
        public CardDetail CardDetails { get; set; }

        [JsonProperty("accountPayments")]
        public AccountDetail[] AccountPayments { get; set; }

        [JsonProperty("customer")]
        public CustomerDto Customer { get; set; }

    }

}
