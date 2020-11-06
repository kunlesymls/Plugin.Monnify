using Newtonsoft.Json;

using System;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class ReserveAccountWithLimitResponseBody
    {
        [JsonProperty("contractCode")]
        public string ContractCode { get; set; }

        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("BankName")]
        public string bankName { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("reservationReference")]
        public string ReservationReference { get; set; }


        [JsonProperty("limitProfileConfig")]
        public LimitProfileConfig LimitProfileConfig { get; set; }
    }
}
