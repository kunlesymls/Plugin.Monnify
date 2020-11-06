using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class OneTimeTransactionResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public OneTimeTransactionResponseBody ResponseBody { get; set; }
    }

}
