using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22 August 2014
//https://judge.softuni.bg/Contests/Practice/Index/23#2

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            int width = 3 * n;
            int dots = n - 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', width - dots * 2 - 2));
                dots--;    
            }

            Console.WriteLine("{0}{1}{0}", new string('*', dots + 1), new string('.', width - (2 * (dots + 1))));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*", new string('.', width - 2));
            }

            Console.WriteLine("{0}", new string('*', width));
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n / 2), new string('.', n / 2 - 1), new string('.', n - 2));
            }

            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n / 2), new string('*', n / 2 - 1), new string('.', n - 2));
        }
    }
}
