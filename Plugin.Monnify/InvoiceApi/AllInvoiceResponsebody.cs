using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.InvoiceApi
{
    public class AllInvoiceResponsebody : PagingDTO
    {
        [JsonProperty("content")]
        public InvoiceResponsebody[] Content { get; set; }
    }
}
