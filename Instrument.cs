using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    public class Instrument
    {
        [JsonProperty(PropertyName = "margin_initial_ratio")]
        public double MarginInitialRatio { get; set; }

        [JsonProperty(PropertyName = "rhs_tradability")]
        public string RhsTrabability { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "market")]
        public string Market { get; set; }

        [JsonProperty(PropertyName = "simple_name")]
        public string SimpleName { get; set; }

        [JsonProperty(PropertyName = "min_tick_size")]
        public string MinTickSize { get; set; }

        [JsonProperty(PropertyName = "maintenance_ratio")]
        public double MaintenanceRatio { get; set; }

        [JsonProperty(PropertyName = "tradability")]
        public string Trabability { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "tradeable")]
        public bool Tradable { get; set; }

        [JsonProperty(PropertyName = "fundamentals")]
        public string FundamentalsUrl { get; set; }

        [JsonProperty(PropertyName = "quote")]
        public string QuoteUrl { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "day_trade_ratio")]
        public double DayTradeRatio { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "tradable_chain_id")]
        public string TradableChainId { get; set; }

        [JsonProperty(PropertyName = "splits")]
        public string SplitsUrl { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "bloomberg_unique")]
        public string BloombergUnique { get; set; }

        [JsonProperty(PropertyName = "list_date")]
        public string ListDate { get; set; }

        public Instrument()
        {
        }
    }
}
