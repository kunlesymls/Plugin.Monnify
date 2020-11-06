
using Newtonsoft.Json;

namespace Plugin.Monnify.SubAccountApi
{
    public class DeleteSubAccountRequest
    {
        /// <summary>
        /// *Required* The unique reference for the sub account will be returned in the response
        /// </summary>
        [JsonProperty("subAccountCode")]
        public string SubAccountCode { get; set; }
    }

}
