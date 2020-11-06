using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public class Pageable
    {
        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("unpaged")]
        public bool Unpaged { get; set; }

        [JsonProperty("paged")]
        public bool Paged { get; set; }
    }

}
