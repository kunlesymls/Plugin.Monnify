using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BatchTransactionResponse
    {
        [JsonProperty("responseBody")]
        public BatchTransactionResponseBody ResponseBody { get; set; }
    }



}
