using System;
namespace RobinHood
{
    public class Stock
    {
        /// <summary>
        /// Gets or sets the shares.
        /// </summary>
        /// <value>The shares.</value>
        public int Shares { get; set; }

        /// <summary>
        /// The ticker name of the stock. ie $AMZA
        /// </summary>
        /// <value>The ticker.</value>
        public string Ticker { get; set; }

        /// <summary>
        /// The current price of the stock.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }

        public double Equity 
        {
            get
            {
                return this.Shares * this.Price;
            }
        }

        public Stock()
        {
            
        }
    }
}
