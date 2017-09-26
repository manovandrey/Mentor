using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinagle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            Console.WriteLine("{0}", new string('#', width));
            int dots = 1;
            int whitespaces = 1;
            for (int i = 0; i < n; i++)
            {
                if (i != n / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots), new string('#', (width - 2 * dots - whitespaces) / 2), new string(' ', whitespaces));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', dots), new string('#', (width - 2 * dots - whitespaces) / 2), new string(' ', (whitespaces - 3) / 2));
                }

                dots++;
                whitespaces  += 2;
            }

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', width - 2 * dots));
                dots++;
            }
        }
    }
}
