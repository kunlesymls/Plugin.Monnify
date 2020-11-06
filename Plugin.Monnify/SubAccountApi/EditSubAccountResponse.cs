
using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.SubAccountApi
{
    public class EditSubAccountResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public CreateSubAccountResponseBody ResponseBody { get; set; }
    }


}
