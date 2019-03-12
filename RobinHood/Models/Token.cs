using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    public class Token
    {
        private const string FileName = "Token.txt";

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "mfa_code")]
        public string MfaCode { get; set; }

        [JsonProperty(PropertyName = "backup_code")]
        public string BackupCode { get; set; }

        public Token()
        {
            
        }

        public void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(this);
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                sw.WriteLine(json);
            }
        }

        public static Token LoadFromFile()
        {
            Token token;
            using (StreamReader sr = new StreamReader(FileName))
            {
                string data = sr.ReadToEnd();
                token = JsonConvert.DeserializeObject<Token>(data);
            }

            return token;
        }
    }
}
