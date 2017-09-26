using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            int arrivedHours = int.Parse(Console.ReadLine());
            int arrivedMinutes = int.Parse(Console.ReadLine());

            int startTime = startHours * 60 + startMinutes;
            int arrivedTime = arrivedHours * 60 + arrivedMinutes;

            if (startTime >= arrivedTime)
            {
                if (startTime - arrivedTime <= 30)
                {
                    Console.WriteLine("On time");
                }
                else if (startTime - arrivedTime > 30)
                {
                    Console.WriteLine("Early");
                }

                if (startTime - arrivedTime < 60)
                {
                    Console.WriteLine("{0} minutes before the start", startTime - arrivedTime);

                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", (startTime - arrivedTime) / 60, (startTime - arrivedTime) % 60);
                }



            }
            else if(startTime < arrivedTime)
            {
                Console.WriteLine("Late");

                if (arrivedTime - startTime < 60)
                {
                    Console.WriteLine("{0} minutes after the start", arrivedTime - startTime);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", (arrivedTime - startTime) / 60, (arrivedTime - startTime) % 60);
                }
            }
        }
    }
}
