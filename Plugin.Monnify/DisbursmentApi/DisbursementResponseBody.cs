using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class DisbursementResponseBody
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }
    }
}
