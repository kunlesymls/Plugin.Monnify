using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class GetReserveAccountTransactionResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public GetReserveAccountTransactionResponsebody ResponseBody { get; set; }
    }

    public class DeleteReserveAccountResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public CreateReserveAccountResponseBody ResponseBody { get; set; }
    }

}
