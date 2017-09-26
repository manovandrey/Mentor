using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            int outsideDots = n;
            int dashes = 2 * n - 1;

            for (int i = 0; i < n - 1; i++)
            {
                outsideDots--;
                dashes += 2;
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', outsideDots), new string('_', dashes));

            }

            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_', ((n * 4 + 3) - 9) / 2));
            outsideDots = 0;
            dashes = (n * 4 + 3) - 4;
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', outsideDots), new string('_', dashes));
                outsideDots++;
                dashes -= 2;
            }
        }
    }
}
