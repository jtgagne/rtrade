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
        /// <value>The OA uth token.</value>
        private Token OAuthToken { get; set; }

        /// <summary>
        /// Used to construct the login request. 
        /// </summary>
        /// <value>The login.</value>
        private LoginRequest Login { get; set; }

        public List<Position> Positions { get; private set; } = new List<Position>();

        public RobinHood(string user, string password)
        {
            this.Login = new LoginRequest
            {
                User = user,
                Password = password
            };

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

        private bool IsPreviousTokenValid()
        {
            bool valid = true;
            try
            {
                this.OAuthToken = Token.LoadFromFile();

                this.Client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue(this.OAuthToken.TokenType, this.OAuthToken.AccessToken);

                HttpResponseMessage response = this.Client.GetAsync(Urls.Positions).Result;

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
    }
}
