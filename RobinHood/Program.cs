using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RobinHood
{
    class MainClass
    {
        private static RobinHood Session { get; set; }

        public static void Main(string[] args)
        {
            try
            {
                Session = new RobinHood();
                Session.Authenticate();
                Session.LoadPositions();
                Session.LoadAccount();
                Session.LoadCryptoPositions();
                Session.LoadHoldings();

                foreach(Position position in Session.Positions)
                {
                    Console.WriteLine(position);
                }

                Position p = Session.Positions[0];
                var result = Session.Client.GetAsync(p.Instrument).Result;
                string resultString = result.Content.ReadAsStringAsync().Result;
                Instrument instrument = JsonConvert.DeserializeObject<Instrument>(resultString);
                StockInfo stockInfo = Session.GetStockInfo(instrument.Symbol);


                result = Session.Client.GetAsync(instrument.QuoteUrl).Result;
                resultString = result.Content.ReadAsStringAsync().Result;
                Quote quote = JsonConvert.DeserializeObject<Quote>(resultString);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
