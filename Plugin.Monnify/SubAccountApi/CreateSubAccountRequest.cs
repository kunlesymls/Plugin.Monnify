using Newtonsoft.Json;

namespace Plugin.Monnify.SubAccountApi
{
    public class CreateSubAccountRequest
    {
        [JsonProperty("subAccountRequestDetail")]
        public SubAccountRequestDetail[] SubAccountRequestDetail { get; set; }
    }
}
