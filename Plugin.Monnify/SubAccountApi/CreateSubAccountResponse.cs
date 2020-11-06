
using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.SubAccountApi
{
    public class CreateSubAccountResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public CreateSubAccountResponseBody[] ResponseBody { get; set; }
    }
}
