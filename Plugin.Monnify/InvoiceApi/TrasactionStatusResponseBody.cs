using Newtonsoft.Json;

using System;

namespace Plugin.Monnify.InvoiceApi
{
    public class TrasactionStatusResponseBody
    {
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; } = "NGN";

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonProperty("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }
    }
}
