using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BatchTransactionResponseBody : PagingDTO
    {
        [JsonProperty("content")]
        public SingleTransferDetailResponseBody[] Content { get; set; }
    }



}
