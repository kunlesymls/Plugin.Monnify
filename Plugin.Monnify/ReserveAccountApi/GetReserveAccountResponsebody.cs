using Newtonsoft.Json;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class GetReserveAccountResponsebody
    {
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("reservationReference")]
        public string ReservationReference { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonProperty("transactionCount")]
        public int TransactionCount { get; set; }
    }


}
