using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BatchTransferDetailResponseBody
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("totalFee")]
        public float TotalFee { get; set; }

        [JsonProperty("batchReference")]
        public string BatchReference { get; set; }

        [JsonProperty("totalTransactions")]
        public int TotalTransactions { get; set; }

        [JsonProperty("failedCount")]
        public int FailedCount { get; set; }

        [JsonProperty("successfulCount")]
        public int SuccessfulCount { get; set; }

        [JsonProperty("pendingCount")]
        public int PendingCount { get; set; }

        [JsonProperty("batchStatus")]
        public string BatchStatus { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }
    }
}
