﻿
using Newtonsoft.Json;

namespace Plugin.Monnify.Helpers
{
    public abstract class BaseResponse
    {
        [JsonProperty("requestSuccessful")]
        public bool RequestSuccessful { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }
    }

}
