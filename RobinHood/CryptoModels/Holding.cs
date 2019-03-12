using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RobinHood.CryptoModels
{
    public class Holding
    {
        [JsonProperty(PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// A list containing all prices paid for this crypto asset.
        /// </summary>
        /// <value>The costs.</value>
        [JsonProperty(PropertyName = "cost_bases")]
        public List<CostBases> Costs { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The type of crypto currency held.
        /// </summary>
        /// <value>The cryto coin.</value>
        [JsonProperty(PropertyName = "currency")]
        public Currency CrytoCoin { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Total quantity held in the account.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty(PropertyName = "quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// Total quantity held in the account that is availble to sell.
        /// </summary>
        /// <value>The quantity available.</value>
        [JsonProperty(PropertyName = "quantity_available")]
        public double QuantityAvailable { get; set; }

        [JsonProperty(PropertyName = "quantity_held_for_buy")]
        public double QuantityHeldForBuy { get; set; }

        [JsonProperty(PropertyName = "quantity_held_for_sell")]
        public double QuantityHeldForSell { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        public Holding()
        {
        }
    }
}
