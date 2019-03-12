using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RobinHood
{
    public class RestClient
    {
        /// <summary>
        /// The HttpClient used to make connections to the robinhood API. All requests made
        /// should be relative to the API BASE URL.
        /// </summary>
        /// <value>The client.</value>

        public HttpClient Client { get; set; }

        public JsonSerializerSettings SerializeSettings { get; set; }

        public RestClient(HttpClient client, string baseUrl)
        {
            Client = client;
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Client.BaseAddress = new Uri(baseUrl);
            SerializeSettings = new JsonSerializerSettings();
        }

        public RestClient(HttpClient client, string baseUrl, JsonSerializerSettings settings) : this(client, baseUrl)
        {
            SerializeSettings = settings;
        }

        public T HttpPost<T>(string endpoint, object body)
        {
            var sendContent = GetStringContent(body);
            var content = Client.PostAsync(endpoint, sendContent).Result;
            string result = content.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        public T HttpPut<T>(string endpoint, object body)
        {
            var sendContent = GetStringContent(body);
            var content = Client.PutAsync(endpoint, sendContent).Result;
            string result = content.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        public T HttpGet<T>(string endpoint)
        {
            return HttpGet<T>(endpoint, null);
        }

        public T HttpGet<T>(string endpoint, Dictionary<string, string> query)
        {
            // Add query to end of url
            endpoint = AddQueryParams(endpoint, query);
            var content = Client.GetAsync(endpoint).Result;
            string result = content.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        public T HttpDelete<T>(string endpoint)
        {
            return HttpDelete<T>(endpoint, null);
        }

        public T HttpDelete<T>(string endpoint, Dictionary<string, string> query)
        {
            // Add query to end of url
            endpoint = AddQueryParams(endpoint, query);
            var content = Client.DeleteAsync(endpoint).Result;
            string result = content.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        private string AddQueryParams(string endpoint, Dictionary<string, string> query)
        {
            if (query != null)
            {
                endpoint += "?";
                foreach (KeyValuePair<string, string> kv in query)
                {
                    endpoint += kv.Key + "=" + kv.Value;
                }
            }

            return endpoint;
        }

        private StringContent GetStringContent(object body)
        {
            string jsonBody = JsonConvert.SerializeObject(body, SerializeSettings);
            var sendContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            return sendContent;
        }
    }
}
