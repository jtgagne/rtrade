using System;
using Newtonsoft.Json;

namespace RobinHood
{
    public class Quote
    {
        [JsonProperty(PropertyName = "adjusted_previous_close")]
        public double AdjustedPreviousClose { get; set; }

        [JsonProperty(PropertyName = "ask_price")]
        public double AskPrice { get; set; }

        [JsonProperty(PropertyName = "ask_size")]
        public double AskSize { get; set; }

        [JsonProperty(PropertyName = "bid_price")]
        public double BidPrice { get; set; }

        [JsonProperty(PropertyName = "bid_size")]
        public double BidSize { get; set; }

        [JsonProperty(PropertyName = "has_traded")]
        public bool HasTraded { get; set; }

        [JsonProperty(PropertyName = "instrument")]
        public string InstrumentUrl { get; set; }

        [JsonProperty(PropertyName = "last_extended_hours_trade_price")]
        public double LastExtendedHoursTradePrice { get; set; }

        [JsonProperty(PropertyName = "last_trade_price")]
        public double LastTradePrice { get; set; }

        [JsonProperty(PropertyName = "last_trade_price_source")]
        public string LastTradePriceSource { get; set; }

        [JsonProperty(PropertyName = "previous_close")]
        public double PreviousClosePrice { get; set; }

        [JsonProperty(PropertyName = "previous_close_date")]
        public string PreviousCloseDate { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "trading_halted")]
        public bool TradingHalted { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        public Quote()
        {
        }
    }
}
