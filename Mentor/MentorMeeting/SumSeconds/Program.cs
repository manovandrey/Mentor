using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sumtime = time1 + time2 + time3;

            int resultMinutes = sumtime / 60;
            int resultSeconds = sumtime % 60;

            Console.WriteLine("{0}:{1:00}", resultMinutes, resultSeconds);
        }
    }
}
