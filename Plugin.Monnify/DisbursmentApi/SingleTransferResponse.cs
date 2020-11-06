using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class SingleTransferResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public DisbursementResponseBody ResponseBody { get; set; }
    }
}
