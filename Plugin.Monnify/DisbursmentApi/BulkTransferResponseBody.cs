using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BulkTransferResponseBody
    {
        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty("totalFee")]
        public decimal TotalFee { get; set; }

        [JsonProperty("batchReference")]
        public string BatchReference { get; set; }

        [JsonProperty("batchStatus")]
        public string BatchStatus { get; set; }

        [JsonProperty("totalTransactions")]
        public int TotalTransactions { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }
    }
}
