using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class AuthorizeTransferRequest
    {
        /// <summary>
        /// *Required* The unique reference for a transaction. Also to be specified for each transaction in a bulk transaction request.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// *Required* The One Time Password sent to the specified email to be used to authenticate the transaction.
        /// </summary>
        [JsonProperty("authorizationCode")]
        public string AuthorizationCode { get; set; }
    }



}
