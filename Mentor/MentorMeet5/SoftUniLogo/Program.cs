using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://judge.softuni.bg/Contests/Practice/Index/480#4
namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 12 * n - 5;


            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - (i * 6 + 1)) / 2), new string('#', i * 6 + 1));
            }
            Console.WriteLine("{0}", new string('#', width));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', (width - (width - ((i + 1) * 6))) / 2 - 1), new string('#', width - ((i + 1) * 6)), new string('.', (width - (width - ((i + 1) * 6))) / 2));
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', (width - (width - ((n - 1) * 6))) / 2 - 1), new string('#', width - ((n - 1) * 6)), new string('.', (width - (width - ((n - 1) * 6))) / 2));

            }

            Console.WriteLine("@{0}{1}{2}", new string('.', (width - (width - ((n - 1) * 6))) / 2 - 1), new string('#', width - ((n - 1) * 6)), new string('.', (width - (width - ((n - 1) * 6))) / 2));

        }
    }
}
