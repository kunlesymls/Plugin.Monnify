using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class GetReserveAccountResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public GetReserveAccountResponsebody ResponseBody { get; set; }
    }


}
