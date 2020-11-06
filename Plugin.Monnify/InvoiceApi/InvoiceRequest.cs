using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

using System.Collections.Generic;

namespace Plugin.Monnify.InvoiceApi
{
    public class InvoiceRequest
    {
        /// <summary>
        /// *Required* The amount to be paid by the customer
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// *Required* Merchant's Unique reference for the invoice
        /// </summary>
        [JsonProperty("invoiceReference")]
        public string InvoiceReference { get; set; }

        /// <summary>
        /// Required if the customer already have a reserved account for invoice
        /// </summary>
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// *Required* Description of the transaction. Will be used as the account name for bank transfer payments
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// *Required* Currency Code for reserved account. Value should be NGN
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// *Required* Contract Code, check your Monnify dashboard on the settings page.
        /// </summary>
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        /// <summary>
        /// *Required* The email address of the customer
        /// </summary>
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// *Required* Full name of the customer
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// *Required* 10-30 12:00:00 (string, required) - 
        /// The expiry date for the invoice. After this date, the customer will no longer be able to pay for that invoice. 
        /// The format is YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// *Required* A URL which customer will be redirected to when payment is successfully completed on the Web SDK.
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>Object containing specifications of the payment method which the customer will use to make the payments. 
        /// This can be set as "ACCOUNT_TRANSFER" or "CARD" . If not set, this would default to the enabled methods in the contract detail.
        /// A URL which customer will be redirected to when payment is successfully completed on the Web SDK.
        /// </summary>
        [JsonProperty("paymentMethods")]
        public string[] PaymentMethods { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public List<Incomesplitconfig> IncomeSplitConfig { get; set; }


    }

}
