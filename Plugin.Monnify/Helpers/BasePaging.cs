
using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public abstract class BasePaging
    {
        /// <summary>
        /// *Required*
        /// Page to be returned.First page is 0 Example: 0
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// *Required*
        /// Contract Code, See your Monnify dashboard
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }
    }

}
