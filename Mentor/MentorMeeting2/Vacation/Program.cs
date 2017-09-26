using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            string summer = "summer";
            string winter = "winter";
            double cash = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            bool isInEurope = false;
            double spentMoney = 0;
            if (cash <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season==summer)
                {
                    spentMoney = cash * 0.3;
                }
                else
                {
                    spentMoney = cash * 0.7;
                }

            }
            else if (cash <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == summer)
                {
                    spentMoney = cash * 0.4;
                }
                else
                {
                    spentMoney = cash * 0.8;
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                spentMoney = cash * 0.9;
                isInEurope = true;
            }


            if (season == winter || isInEurope)
            {
                Console.WriteLine("Hotel - {0:f2}", spentMoney);
            }
            else if (season == summer)
            {
                Console.WriteLine("Camp - {0:f2}", spentMoney);
            }


        }
    }
}
