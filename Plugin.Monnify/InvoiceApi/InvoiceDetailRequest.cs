using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class InvoiceDetailRequest
    {
        /// <summary>
        /// *Required* Merchant's Unique reference for the invoice
        /// </summary>
        [JsonProperty("invoiceReference")]
        public string InvoiceReference { get; set; }
    }

}
