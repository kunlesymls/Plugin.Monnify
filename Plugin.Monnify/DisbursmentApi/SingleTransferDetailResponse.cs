using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class SingleTransferDetailResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public SingleTransferDetailResponseBody ResponseBody { get; set; }
    }
}
