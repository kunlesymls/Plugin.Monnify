using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class UpdateReserveAccountWithLimitRequest
    {
        /// <summary>
        /// *Required*
        /// Your unique reference used to identify this reserved account e.g ref12345
        /// </summary>
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// *Required* This Limit Profile code is the unique identifier for the Limit Profile used to reference the Limit Profile
        /// </summary>
        [JsonProperty("limitProfileCode")]
        public string LimitProfileCode { get; set; }
    }
}
