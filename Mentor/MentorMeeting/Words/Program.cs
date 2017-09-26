using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes >= 45)
            {
                minutes = minutes + 15 - 60;
                if (hours == 23)
                {
                    hours = 0;
                }
                else
                {
                    hours++;
                }
            }
            else
            {
                minutes += 15;
            }

            Console.WriteLine("{0}:{1:00}", hours, minutes);
        }
    }
}
