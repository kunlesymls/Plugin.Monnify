
using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public class Sort
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool empty { get; set; }
    }

}
