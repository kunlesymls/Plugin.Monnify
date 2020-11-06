using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class Product
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }


}
