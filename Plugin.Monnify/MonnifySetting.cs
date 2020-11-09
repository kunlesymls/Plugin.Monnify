namespace Plugin.Monnify
{
    public class MonnifySetting
    {
        public string BaseUrl { get; set; } = "https://sandbox.monnify.com/api/v1/";
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string ContractCode { get; set; }
    }
}
