using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class OneTimeTransactionResponseBody
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("enabledPaymentMethod")]
        public string[] EnabledPaymentMethod { get; set; }

        [JsonProperty("checkoutUrl")]
        public string CheckoutUrl { get; set; }
        public Incomesplitconfig[] incomeSplitConfig { get; set; }
    }


}
