using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.LimitProfileApi
{
    public class CreateLimitProfileResponses : BaseResponse
    {
        [JsonProperty("responseBody")]
        public CreateLimitProfileResponsesBody ResponseBody { get; set; }
    }
}
