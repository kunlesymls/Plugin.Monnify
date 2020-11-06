using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class GetReserveAccountTransactionResponsebody : PagingDTO
    {
        [JsonProperty("content")]
        public Content[] Content { get; set; }
    }

}
