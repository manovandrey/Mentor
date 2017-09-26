using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18 December 2016
//https://judge.softuni.bg/Contests/Practice/Index/368#4

namespace CristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = (4 * n - 2) / 2;

            Console.WriteLine("{0}/|\\{0}", new string('.', dots));
            Console.WriteLine("{0}\\|/{0}", new string('.', dots));
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots), new string('-', i));
                dots--;
            }

            Console.WriteLine("{0}", new string('*', 4 * n + 1));
            for (int i = 0; i < 2 * n ; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', 4 * n + 1));

        }
    }
}
