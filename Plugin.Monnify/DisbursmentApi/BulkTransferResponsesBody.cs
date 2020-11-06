using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BulkTransferResponsesBody : PagingDTO
    {
        [JsonProperty("content")]
        public BulkTransferResponseBody[] Content { get; set; }
    }
}
