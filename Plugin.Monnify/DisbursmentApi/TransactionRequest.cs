using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class TransactionRequest
    {
        /// <summary>
        /// *Required* The unique reference for a transaction. Also to be specified for each transaction in a bulk transaction request.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
