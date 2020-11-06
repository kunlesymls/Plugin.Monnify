using Newtonsoft.Json;

namespace Plugin.Monnify.LimitProfileApi
{
    public class CreateLimitProfileResponseBody
    {
        [JsonProperty("limitProfileCode")]
        public string LimitProfileCode { get; set; }

        [JsonProperty("limitProfileName")]
        public string LimitProfileName { get; set; }

        [JsonProperty("singleTransactionValue")]
        public int SingleTransactionValue { get; set; }

        [JsonProperty("dailyTransactionVolume")]
        public int DailyTransactionVolume { get; set; }

        [JsonProperty("dailyTransactionValue")]
        public int DailyTransactionValue { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }
}
