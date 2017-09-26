using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//19 March 2017
//https://judge.softuni.bg/Contests/Practice/Index/499#4

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int dots = 1;
            char inSymbol = ' ';

            Console.WriteLine(new string('*', 2 * n + 1));
            for (int i = 0; i < n - 1; i++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string(inSymbol, (width - 2*dots) - 2));
                dots++;
                inSymbol = '@';


            }


            Console.WriteLine("{0}*{0}", new string('.', dots));

            for (int i = 0; i < n - 2; i++)
            {
                dots--;
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', dots), new string(' ', i));
            }


            dots--;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('@', width - 4));
            Console.WriteLine(new string('*', 2 * n + 1));

        }
    }
}
