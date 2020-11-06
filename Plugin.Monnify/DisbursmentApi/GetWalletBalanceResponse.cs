using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class GetWalletBalanceResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public GetWalletBalanceResponseBody ResponseBody { get; set; }
    }
}
