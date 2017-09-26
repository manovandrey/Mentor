using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//23 July 2017
//https://judge.softuni.bg/Contests/Practice/Index/715#4
namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n;
            int width = 5 * n;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', width - 2 * dots));
                dots++;
            }
            for (int i = 0; i < (n + 2) / 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', width - 2 * dots - 2));
                dots++;
            }

            dots--;
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', width - 2 * dots));
            dots -= 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', width - 2 * dots));
            }

            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (width - 10) / 2));

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', width - 2 * dots));
            }

        }
    }
}
