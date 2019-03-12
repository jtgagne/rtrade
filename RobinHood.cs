using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    public class RobinHood
    {
        /// <summary>
        /// The HttpClient used to make connections to the robinhood API. All requests made
        /// should be relative to the API BASE URL.
        /// </summary>
        /// <value>The client.</value>
        public HttpClient Client { get; set; }

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

        /// <summary>
        /// Gets the positions.
        /// </summary>
        /// <value>The positions.</value>
        public List<Position> Positions { get; private set; } = new List<Position>();

        public RobinHood()
        {
            this.Client = new HttpClient();
            this.Client.DefaultRequestHeaders.Accept.Clear();
            this.Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            this.Client.BaseAddress = new Uri(Urls.Root);
        }

        public async void Authenticate()
        {
            try
            {
                if (!IsPreviousTokenValid())
                {
                    Console.WriteLine("Creating a new access token using the provided credentials");
                    PromptCredentials();
                    var content = new FormUrlEncodedContent(this.Login.ToDictionary());
                    HttpResponseMessage response = this.Client.PostAsync(Urls.Login, content).Result;

                    var responseString = await response.Content.ReadAsStringAsync();
                    this.OAuthToken = JsonConvert.DeserializeObject<Token>(responseString);
                    this.OAuthToken.SaveToFile();

                    this.Client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue(this.OAuthToken.TokenType, this.OAuthToken.AccessToken);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
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

        private bool IsPreviousTokenValid()
        {
            bool valid = true;
            try
            {
                this.OAuthToken = Token.LoadFromFile();

                this.Client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue(this.OAuthToken.TokenType, this.OAuthToken.AccessToken);

                // Exisiting token is invalid or expired.
                HttpResponseMessage response = this.Client.GetAsync(Urls.Positions).Result;
                if(response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    valid = false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Previous token was not valid.");
                Console.WriteLine(e.Message);
                valid = false;
            }

            return valid;
        }

        public void LoadPositions()
        {
            try
            {
                HttpResponseMessage response = this.Client.GetAsync(Urls.Positions).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                Dictionary<string, List<Position>> keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, List<Position>>>(responseString);

                Console.WriteLine("WARNING: NOT CHECKING FOR ALL POSITIONS");
                this.Positions.AddRange(keyValuePairs["results"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public StockInfo GetStockInfo(string symbol)
        {
            StockInfo info = new StockInfo();

            string url = string.Format("{0}{1}/", Urls.Fundamentals, symbol);
            HttpResponseMessage responseMessage = this.Client.GetAsync(url).Result;

            string responseString = responseMessage.Content.ReadAsStringAsync().Result;
            info = JsonConvert.DeserializeObject<StockInfo>(responseString);

            return info;
        }
    }
}
