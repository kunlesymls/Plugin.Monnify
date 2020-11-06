using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class CreateInvoiceReserveAccountRequest
    {

        /// <summary>
        /// *Required*
        ///The name you want to be attached to the reserved account. This will be displayed during name enquiry e.g John Doe
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// *Required*
        /// Your unique reference used to identify this reserved account e.g ref12345
        /// </summary>
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// *Required*
        /// Currency Code for reserved account. Value should be NGN
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; } = "NGN";

        /// <summary>
        /// *Required*
        /// Contract Code, See your Monnify dashboard
        /// </summary>
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        /// <summary>
        /// *Required*
        /// Full name of the customer who the account is being reserved for. 
        /// In most cases the Customer Name and Account Name can be thesame
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// *Required*
        /// Email address of the customer who the account is being reserved for. This is the unique identifier for each customer e.g john @doe.com        
        /// </summary>
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Required
        /// BVN of the customer the account is being reserved for. Please note that if BVN is not supplied there will be low limits on the reserved account
        /// </summary>                
        [JsonProperty("customerBVN")]
        public string CustomerBVN { get; set; }

        /// <summary>
        /// *Required* This differentiates this account as an Invoice Type account.
        /// </summary>
        [JsonProperty("reservedAccountType")]
        public string ReservedAccountType { get; set; } = "INVOICE";



    }
}
