using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class ResendOTPResponseody
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
