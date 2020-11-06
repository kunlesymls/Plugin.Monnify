using Newtonsoft.Json;

using Plugin.Monnify.Helpers;

using System;
using System.Collections.Generic;

namespace Plugin.Monnify.ReserveAccountApi
{
    public class CreateReserveAccountResponseBody
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
        public string BankName { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("reservationReference")]
        public string ReservationReference { get; set; }

        [JsonProperty("reservedAccountType")]
        public string ReservedAccountType { get; set; }

        [JsonProperty("incomeSplitConfig")]
        public List<Incomesplitconfig> IncomeSplitConfig { get; set; }
    }
}
