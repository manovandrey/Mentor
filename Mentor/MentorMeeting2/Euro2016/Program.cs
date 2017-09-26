using System;


namespace Euro2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transportCash;

            if (people < 5)
            {
                transportCash = cash * 0.75;
            }
            else if(people < 10)
            {
                transportCash = cash * 0.6;
            }
            else if (people < 25)
            {
                transportCash = cash * 0.5;
            }
            else if (people < 50)
            {
                transportCash = cash * 0.4;
            }
            else
            {
                transportCash = cash * 0.25;
            }

            double moneyLeft = cash - transportCash;
            double ticketsPrice = 0;
            if (type == "Normal")
            {
                ticketsPrice = people * 249.99;
            }
            else
            {
                ticketsPrice = people * 499.99;
            }

            if (ticketsPrice <= moneyLeft)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - ticketsPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketsPrice));
            }

        }
    }
}
