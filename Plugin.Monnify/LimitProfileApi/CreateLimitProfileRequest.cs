using Newtonsoft.Json;

namespace Plugin.Monnify.LimitProfileApi
{
    public class CreateLimitProfileRequest
    {
        /// <summary>
        /// *Required* The name of the Limit Profile
        /// </summary>
        [JsonProperty("limitProfileName")]
        public string LimitProfileName { get; set; }

        /// <summary>
        /// *Required* The maximum amount that can be allowed per transaction on the reserved accounts.
        /// </summary>
        [JsonProperty("singleTransactionValue")]
        public int SingleTransactionValue { get; set; }

        /// <summary>
        /// *Required* The maximum number of transaction count per day allowed on the reserved accounts.
        /// </summary>
        [JsonProperty("dailyTransactionVolume")]
        public int DailyTransactionVolume { get; set; }

        /// <summary>
        /// *Required* The maximum amount per day in all transactions that can be allowed on the reserved accounts.
        /// </summary>
        [JsonProperty("dailyTransactionValue")]
        public int DailyTransactionValue { get; set; }
    }
}
