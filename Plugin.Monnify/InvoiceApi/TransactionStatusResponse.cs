using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class TransactionStatusResponse : BaseResponse
    {

        [JsonProperty("responseBody")]
        public TrasactionStatusResponseBody ResponseBody { get; set; }
    }

}
