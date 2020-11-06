using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BulkTransferResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public BulkTransferResponseBody ResponseBody { get; set; }
    }
}
