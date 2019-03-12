using System;
using Newtonsoft.Json;

namespace RobinHood.CryptoModels
{
    public class Currency
    {
        /// <summary>
        /// The hex color code used to display the crypto currency in the robinhood app.
        /// </summary>
        /// <value>The color of the brand.</value>
        [JsonProperty(PropertyName = "brand_color")]
        public string BrandColor { get; set; }

        /// <summary>
        /// The ticker code of the crypto currency.
        /// </summary>
        /// <value>The code.</value>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The smallest increment in which the crypto currency can be purchased at.
        /// </summary>
        /// <value>The increment.</value>
        [JsonProperty(PropertyName = "increment")]
        public double Increment { get; set; }

        /// <summary>
        /// The full name of the cryptocurrency
        /// </summary>
        /// <value>The market value.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Should always be cryptocurrency.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        public Currency()
        {
        }
    }
}
