using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class InvoiceResponsebody
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("invoiceReference")]
        public string InvoiceReference { get; set; }

        [JsonProperty("invoiceStatus")]
        public string InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("checkoutUrl")]
        public string CheckoutUrl { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

    }

}
