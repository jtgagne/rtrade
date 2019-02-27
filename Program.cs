using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace RobinHood
{
    class MainClass
    {
        private static RobinHood Session { get; set; }

        public static void Main(string[] args)
        {
            try
            {
                Session = new RobinHood("emailOrUserName", "password");
                Session.Authenticate();
                Session.LoadPositions();

                foreach(Position position in Session.Positions)
                {
                    Console.WriteLine(position);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
