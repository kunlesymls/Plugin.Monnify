using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

using System;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class Content
    {
        [JsonProperty("customerDTO")]
        public CustomerDto CustomerDTO { get; set; }

        [JsonProperty("providerAmount")]
        public int ProviderAmount { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        [JsonProperty("providerCode")]
        public string ProviderCode { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("completedOn")]
        public DateTime CompletedOn { get; set; }

        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        [JsonProperty("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("merchantCode")]
        public string MerchantCode { get; set; }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("settleInstantly")]
        public bool SettleInstantly { get; set; }

        [JsonProperty("payableAmount")]
        public int PayableAmount { get; set; }

        [JsonProperty("amountPaid")]
        public int AmountPaid { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("paymentMethodList")]
        public object[] PaymentMethodList { get; set; }

        [JsonProperty("collectionChannel")]
        public string CollectionChannel { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }
    }

}
