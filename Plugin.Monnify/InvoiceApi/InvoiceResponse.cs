using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class InvoiceResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public InvoiceResponsebody ResponseBody { get; set; }
    }
}
