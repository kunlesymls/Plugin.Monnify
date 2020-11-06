using Newtonsoft.Json;

namespace Plugin.Monnify.DisbursmentApi
{
    public class GetWalletBalanceResponseBody
    {
        [JsonProperty("availableBalance")]
        public long AvailableBalance { get; set; }

        [JsonProperty("ledgerBalance")]
        public long LedgerBalance { get; set; }
    }
}
