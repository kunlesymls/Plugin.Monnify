using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class AuthenticationResponseBody
    {
        [JsonProperty("AccessToken")]
        public string accessToken { get; set; }

        [JsonProperty("expiresIn")]
        public string ExpiresIn { get; set; }
    }

}
