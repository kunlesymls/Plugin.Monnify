using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class AuthenticationResponse : BaseResponse
    {

        [JsonProperty("responseBody")]
        public AuthenticationResponseBody ResponseBody { get; set; }
    }

}
