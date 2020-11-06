using Newtonsoft.Json;

namespace Plugin.Monnify.InvoiceApi
{
    public class CardDetail
    {
        [JsonProperty("cardType")]
        public object CardType { get; set; }

        [JsonProperty("authorizationCode")]
        public object AuthorizationCode { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("expMonth")]
        public string ExpMonth { get; set; }

        [JsonProperty("expYear")]
        public string ExpYear { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }
    }


}
