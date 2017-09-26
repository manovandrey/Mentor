using System;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double styrofoamInPacket = double.Parse(Console.ReadLine());
            double styrofoamPrice = double.Parse(Console.ReadLine());

            double styrofoamArea = (houseArea - windowsCount * 2.4) * 1.1;

            double packets = Math.Ceiling(styrofoamArea / styrofoamInPacket);

            double moneysSpent = packets * styrofoamPrice;

            if (money >= moneysSpent)
            {
                Console.WriteLine("Spent: {0:f2}", moneysSpent);
                Console.WriteLine("Left: {0:f2}", money - moneysSpent);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", moneysSpent - money);
            }

        }
    }
}
