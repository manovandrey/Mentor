using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^',n / 2), new string('_',(2 * n - 4 - (n/2) * 2)));
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2*n - 2));
            }

            Console.WriteLine("|{0} {1} {0}|", new string(' ', n / 2), new string('_', (2 * n - 4 - (n / 2) * 2)));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', (2 * n - 4 - (n / 2) * 2)));
        }
    }
}
