using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.LimitProfileApi
{
    public class CreateLimitProfileResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public CreateLimitProfileResponseBody ResponseBody { get; set; }
    }
}
