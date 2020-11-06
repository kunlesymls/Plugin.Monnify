using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

namespace Plugin.Monnify.LimitProfileApi
{
    public class CreateLimitProfileResponsesBody : PagingDTO
    {
        [JsonProperty("content")]
        public CreateLimitProfileResponseBody[] Content { get; set; }
    }
}
