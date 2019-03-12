using System;
using Newtonsoft.Json;
namespace RobinHood.CryptoModels
{
    public class CryptoPortfolio
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "account_id")]
        public string AccountId { get; set; }

        [JsonProperty(PropertyName = "equity")]
        public double Equity { get; set; }

        [JsonProperty(PropertyName = "extended_hours_equity")]
        public double ExtendedHoursEquity { get; set; }

        [JsonProperty(PropertyName = "market_value")]
        public double MarketValue { get; set; }

        [JsonProperty(PropertyName = "extended_hours_market_value")]
        public double ExtendedHoursMarketValue { get; set; }

        [JsonProperty(PropertyName = "previous_close")]
        public double PreviousClose { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        public CryptoPortfolio()
        {
        }
    }
}
