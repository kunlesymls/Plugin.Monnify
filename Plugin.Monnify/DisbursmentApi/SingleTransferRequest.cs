using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class SingleTransferRequest
    {
        /// <summary>
        /// *Required* The amount to be disbursed to the beneficiary.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// *Required* The unique reference for a transaction. Also to be specified for each transaction in a bulk transaction request.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// *Required* The Narration for the transactions being processed.
        /// </summary>
        [JsonProperty("narration")]
        public string Narration { get; set; }

        /// <summary>
        /// *Required* The 3 digit bank code representing the destination bank.
        /// </summary>
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        /// <summary>
        /// *Required* The beneficiary account number.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// *Required* The currency of the transaction being initialized. "NGN".
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// *Required* Unique reference to identify the wallet to be debited.
        /// </summary>
        [JsonProperty("walletId")]
        public string WalletId { get; set; }
    }
}
