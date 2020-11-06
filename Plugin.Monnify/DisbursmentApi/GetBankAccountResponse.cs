using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class GetBankAccountResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public GetBankAccountResponseBody ResponseBody { get; set; }
    }
}
