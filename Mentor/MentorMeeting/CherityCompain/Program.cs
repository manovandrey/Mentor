using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherityCompain
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffes = int.Parse(Console.ReadLine());
            int pencakes = int.Parse(Console.ReadLine());

            double cakesSumPrice = cakes * 45;
            double waffesSumPrice = waffes * 5.8;
            double pencakesSumPrice = pencakes * 3.2;

            double totalPerDay = (cakesSumPrice + waffesSumPrice + pencakesSumPrice) * cookers;

            double total = totalPerDay * days;
            double profit = total - total * 1 / 8;
            Console.WriteLine($"{profit:f2}");
        }
    }
}
