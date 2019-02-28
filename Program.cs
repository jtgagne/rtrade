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

                foreach(Position position in Session.Positions)
                {
                    Console.WriteLine(position);
                }

                Position p = Session.Positions[0];
                var result = Session.Client.GetAsync(p.Instrument).Result;
                string resultString = result.Content.ReadAsStringAsync().Result;
                Instrument instrument = JsonConvert.DeserializeObject<Instrument>(resultString);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
