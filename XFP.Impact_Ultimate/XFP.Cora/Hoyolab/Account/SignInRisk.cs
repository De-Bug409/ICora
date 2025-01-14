﻿namespace XFP.ICora.Hoyolab.Account
{
    public class SignInRisk
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("risk_code")]
        public int RiskCode { get; set; }

        [JsonPropertyName("gt")]
        public string GT { get; set; }

        [JsonPropertyName("challenge")]
        public string Challenge { get; set; }

        [JsonPropertyName("success")]
        public int Success { get; set; }
    }
}
