using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class Contract
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("supportsAdvancedSettlementAccountSelection")]
        public bool SupportsAdvancedSettlementAccountSelection { get; set; }
    }


}
