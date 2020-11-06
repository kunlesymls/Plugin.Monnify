using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BulkTransferResponses : BaseResponse
    {
        [JsonProperty("responseBody")]
        public BulkTransferResponsesBody ResponseBody { get; set; }
    }
}
