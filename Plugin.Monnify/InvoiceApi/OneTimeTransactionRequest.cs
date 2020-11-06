using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

using System.Collections.Generic;

namespace Plugin.Monnify.InvoiceApi
{
    public class OneTimeTransactionRequest
    {
        /// <summary>
        /// *Required* The amount to be paid by the customer
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// *Required* Email address of the customer. This is the unique identifier for each customer
        /// </summary>
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// *Required* Full name of the customer
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// *Required* Phone Number of the customer
        /// </summary>
        [JsonProperty("customerPhoneNumber")]
        public string CustomerPhoneNumber { get; set; }

        /// <summary>
        /// *Required* Merchant's unique reference for the transaction
        /// </summary>
        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// A description of the transaction. Will be used as account name for pay with transfer
        /// </summary>
        [JsonProperty("paymentDescription")]
        public string paymentDescription { get; set; }

        /// <summary>
        /// *Required* Currency Code for the transaction. Value should be NGN
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; } = "NGN";

        /// <summary>
        /// *Required* Contract Code (See your Monnify dashboard)
        /// </summary>
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        /// <summary>
        /// *Required* The URL Monnify should redirect to when the transaction is completed
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }


        [JsonProperty("incomeSplitConfig")]
        public List<Incomesplitconfig> IncomeSplitConfig { get; set; }

    }

}
