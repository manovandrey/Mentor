using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://judge.softuni.bg/Contests/Practice/Index/233#4
namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;


            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', width - 2 * n));

            for (int i = 0; i < n - 1; i++)
            {
                int dots = n - (1 + i);
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', width - 2 * dots - 2));
            }

            Console.WriteLine("{0}", new string('*', width));

            for (int i = 0; i < n * 2; i++)
            {
                int dots = i + 1;
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', width - 2 * dots - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n*2 + 1), new string('*', n - 2));
        }
    }
}
