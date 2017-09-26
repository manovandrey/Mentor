using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}**{0}", new string('-', (n - 2) / 2));


                    int insideDashes = 2;

                    for (int i = 0; i < n - 3; i++)
                    {
                        int outsideDashes = (n - 2 - insideDashes) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', outsideDashes), new string('-', insideDashes));

                        if (i < (n - 3) / 2)
                        {
                            insideDashes += 2;

                        }
                        else
                        {
                            insideDashes -= 2;

                        }
                    }
                    Console.WriteLine("{0}**{0}", new string('-', (n - 2) / 2));
                }
                else
                {
                    Console.WriteLine("{0}*{0}", new string('-', n / 2));

                    int insideDashes = 1;

                    for (int i = 0; i < n - 2; i++)
                    {
                        int outsideDashes = (n - insideDashes - 2) / 2;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', outsideDashes), new string('-', insideDashes));
                        if (i < (n - 2) / 2)
                        {
                            insideDashes += 2;

                        }
                        else
                        {
                            insideDashes -= 2;

                        }

                    }

                    Console.WriteLine("{0}*{0}", new string('-', n / 2));

                }
            }
        }
    }
}
