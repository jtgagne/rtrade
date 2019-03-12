using System;
using Newtonsoft.Json;

namespace RobinHood
{
    public class StockInfo
    {
        [JsonProperty(PropertyName = "open")]
        public double OpenPrice { get; set; }

        [JsonProperty(PropertyName = "high")]
        public double TodaysHigh { get; set; }

        [JsonProperty(PropertyName = "low")]
        public double TodaysLow { get; set; }

        [JsonProperty(PropertyName = "volume")]
        public double Volume { get; set; }

        [JsonProperty(PropertyName = "average_volume")]
        public double AverageVolume { get; set; }

        [JsonProperty(PropertyName = "high_52_weeks")]
        public double High52Weeks { get; set; }

        [JsonProperty(PropertyName = "low_52_weeks")]
        public double Low52Weeks { get; set; }

        [JsonProperty(PropertyName = "market_cap")]
        public double MarketCap { get; set; }

        [JsonProperty(PropertyName = "dividend_yield")]
        public double DividendYield { get; set; }

        [JsonProperty(PropertyName = "pe_ratio")]
        public string PeRatio { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "instrument")]
        public string InstrumentUrl { get; set; }

        public StockInfo()
        {
            
        }
    }
}
