using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class ResendOTPResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public ResendOTPResponseody ResponseBody { get; set; }
    }
}
