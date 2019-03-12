using System;
using Newtonsoft.Json;

namespace RobinHood.CryptoModels
{
    public class CostBases
    {
        [JsonProperty(PropertyName = "currency_id")]
        public string CurrencyId { get; set; }

        /// <summary>
        /// The amount of money spent on the crypto asset
        /// </summary>
        /// <value>The direct cost basis.</value>
        [JsonProperty(PropertyName = "direct_cost_basis")]
        public double DirectCostBasis { get; set; }

        /// <summary>
        /// The quantity of the crypto asset owned
        /// </summary>
        /// <value>The direct quantity.</value>
        [JsonProperty(PropertyName = "direct_quantity")]
        public double DirectQuantity { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "intraday_quantity")]
        public double IntradayQuantity { get; set; }

        [JsonProperty(PropertyName = "intraday_cost_basis")]
        public double IntradayCostBasis { get; set; }

        [JsonProperty(PropertyName = "marked_cost_basis")]
        public double MarkedCostBasis { get; set; }

        [JsonProperty(PropertyName = "marked_quantity")]
        public double MarkedQuantity { get; set; }

        public CostBases()
        {
        }
    }
}
