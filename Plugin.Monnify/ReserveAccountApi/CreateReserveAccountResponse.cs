using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class CreateReserveAccountResponse : BaseResponse
    {

        [JsonProperty("responseBody")]
        public CreateReserveAccountResponseBody ResponseBody { get; set; }
    }
}
