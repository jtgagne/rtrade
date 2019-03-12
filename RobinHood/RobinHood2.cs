using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RobinHood.Properties;

namespace RobinHood
{
    public class RobinHood2 : RestClient
    {

        /// <summary>
        /// Gets the OAuth token.
        /// </summary>
        /// <value>The OAuth token.</value>
        private Token OAuthToken { get; set; }

        /// <summary>
        /// Used to construct the login request. 
        /// </summary>
        /// <value>The login.</value>
        private LoginRequest Login { get; set; }

        public RobinHood2(HttpClient client) : base(client, Settings.Default.BaseWebsite)
        {
        }

        public void Authenticate()
        {
            PromptCredentials();
            OAuthToken = HttpPost<Token>(Settings.Default.LogonEndpoint, Login);
            if (OAuthToken.MfaRequired)
            {
                Console.Write("MFA Code: ");
                string mfaCode = Console.ReadLine();
                Login.MfaCode = mfaCode;
                OAuthToken = HttpPost<Token>(Settings.Default.LogonEndpoint, Login);
            }
            OAuthToken.SaveToFile();
            Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(OAuthToken.TokenType, OAuthToken.AccessToken);
            
        }

        public Dictionary<string, List<Position>> GetPositions()
        {
            return HttpGet<Dictionary<string, List<Position>>>(Settings.Default.PostionsEndpoint);
        }

        public StockInfo GetStockInfo(string symbol)
        {
            string url = string.Format("{0}{1}/", Settings.Default.FundamentalsEndpoint, symbol);
            return HttpGet<StockInfo>(url);
        }

        private void PromptCredentials()
        {
            this.Login = new LoginRequest();
            Console.WriteLine("Enter user name or email:");
            Console.Write(">>>");
            Login.User = Console.ReadLine();
            Console.WriteLine("Enter password:");
            Console.Write(">>>");
            Login.Password  = Console.ReadLine();
        }
    }
}
