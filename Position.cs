using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    public class Position
    {
        [JsonProperty(PropertyName = "shares_held_for_stock_grants")]
        public double SharesHeld { get; set; }

        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        [JsonProperty(PropertyName = "pending_average_buy_price")]
        public double PendingAveragePrice { get; set; }

        [JsonProperty(PropertyName = "shares_held_for_options_events")]
        public double SharesHeldForOptions { get; set; }

        [JsonProperty(PropertyName = "intraday_average_buy_price")]
        public double IntraDayAveragePrice { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "shares_held_for_options_collateral")]
        public double SharesHeldForColateral { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "shares_held_for_buys")]
        public double SharesHeldForBuys { get; set; }

        [JsonProperty(PropertyName = "average_buy_price")]
        public double AveragePrice { get; set; }

        [JsonProperty(PropertyName = "instrument")]
        public string Instrument { get; set; }

        [JsonProperty(PropertyName = "intraday_quantity")]
        public double IntradayQuantity { get; set; }

        [JsonProperty(PropertyName = "shares_held_for_sells")]
        public double SharesHeldForSells { get; set; }

        [JsonProperty(PropertyName = "shares_pending_from_options_events")]
        public double SharesPendingFromOptions { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public double Quantity { get; set; }

        public Position()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Quantity: {0}", this.Quantity));
            sb.AppendLine(string.Format("Average Price: {0}", this.AveragePrice));
            return sb.ToString();
        }
    }
}
