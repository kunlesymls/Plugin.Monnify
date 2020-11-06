
using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public class CustomerDto
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("merchantCode")]
        public string MerchantCode { get; set; }
    }

}
