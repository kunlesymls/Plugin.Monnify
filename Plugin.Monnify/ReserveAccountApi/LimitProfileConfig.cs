using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class LimitProfileConfig
    {
        [JsonProperty("limitProfileCode")]
        public string LimitProfileCode { get; set; }

        [JsonProperty("singleTransactionValue")]
        public string SingleTransactionValue { get; set; }

        [JsonProperty("dailyTransactionVolume")]
        public string DailyTransactionVolume { get; set; }

        [JsonProperty("dailyTransactionValue")]
        public string DailyTransactionValue { get; set; }
    }
}
