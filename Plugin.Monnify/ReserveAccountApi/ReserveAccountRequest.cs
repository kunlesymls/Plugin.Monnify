using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class ReserveAccountRequest
    {
        /// <summary>
        /// *Required*
        /// Your unique reference used to identify this reserved account e.g ref12345
        /// </summary>
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }
    }


}
