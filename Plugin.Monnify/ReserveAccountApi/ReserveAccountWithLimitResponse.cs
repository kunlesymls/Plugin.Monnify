using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class ReserveAccountWithLimitResponse : BaseResponse
    {

        [JsonProperty("responseBody")]
        public ReserveAccountWithLimitResponseBody ResponseBody { get; set; }
    }
}
