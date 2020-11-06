using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class TransactionStatusRequest
    {
        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }
    }

}
