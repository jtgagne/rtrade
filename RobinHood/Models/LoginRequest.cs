using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    public class LoginRequest
    {
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; } = "c82SH0WZOsabOXGP2sxqcj34FxkvfnWRZBKlBjFS";

        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; } = "86400";

        [JsonProperty(PropertyName = "grant_type")]
        public string GrantType { get; set; } = "password";

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; } = "internal";

        [JsonProperty(PropertyName = "username")]
        public string User { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "mfa_code")]
        public string MfaCode { get; set; }


        public LoginRequest()
        {
             
        }

        public Dictionary<string, string> ToDictionary()
        {
            string json = JsonConvert.SerializeObject(this);
            Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return dictionary;
        }
    }
}
