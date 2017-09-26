using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1PerHour = int.Parse(Console.ReadLine());
            int pipe2PerHour = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1Total = pipe1PerHour * hours;
            double pipe2Total = pipe2PerHour * hours;

            double total = pipe1Total + pipe2Total;

            if (total <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Floor((total / volume) * 100), Math.Floor((pipe1Total / total) * 100), Math.Floor((pipe2Total / total) * 100));
            }
            else
            {
                double overflowLiters = total - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflowLiters);
            }

        }
    }
}
