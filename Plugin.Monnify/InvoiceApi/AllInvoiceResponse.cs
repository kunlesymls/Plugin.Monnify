using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class AllInvoiceResponse : BaseResponse
    {
        [JsonProperty("responseBody")]
        public AllInvoiceResponsebody ResponseBody { get; set; }
    }
}
