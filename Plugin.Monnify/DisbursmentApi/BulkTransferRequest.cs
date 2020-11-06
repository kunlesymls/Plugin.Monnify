using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class BulkTransferRequest
    {
        /// <summary>
        /// *Required* The unique reference for the entire batch of transactions being sent.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// *Required* The unique reference for the entire batch of transactions being sent.
        /// </summary>
        [JsonProperty("batchReference")]
        public string BatchReference { get; set; }

        /// <summary>
        /// *Required* The Narration for the transactions being processed.
        /// </summary>
        [JsonProperty("narration")]
        public string Narration { get; set; }

        /// <summary>
        /// *Required* Unique reference to identify the wallet to be debited.
        /// </summary>
        [JsonProperty("walletId")]
        public string WalletId { get; set; }

        [JsonProperty("onValidationFailure")]
        public string OnValidationFailure { get; set; } = "CONTINUE";

        [JsonProperty("notificationInterval")]
        public int NotificationInterval { get; set; } = 10;

        [JsonProperty("transactionList")]
        public IndividualTransfer[] TransactionList { get; set; }

    }
}
