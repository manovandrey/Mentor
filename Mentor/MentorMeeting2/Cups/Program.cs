using System;


namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            double cupPrice = 4.2;

            int cups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHours = 8 * workers * days;
            int cupsMaked = totalHours / 5;
            if (cupsMaked > cups)
            {
                double profit = (cupsMaked - cups) * cupPrice;
                Console.WriteLine("{0:f2} extra money", profit);
            }
            else
            {
                double losses = (cups - cupsMaked) * cupPrice;
                Console.WriteLine("Losses: {0:f2}", losses);
            }

        }
    }
}
