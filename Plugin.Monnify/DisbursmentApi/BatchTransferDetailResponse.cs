using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BatchTransferDetailResponse
    {
        [JsonProperty("responseBody")]
        public BatchTransferDetailResponseBody ResponseBody { get; set; }
    }



}
