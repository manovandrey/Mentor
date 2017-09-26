using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1to100Words
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                if (n < 20)
                {
                    if (n == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    else if (n == 1)
                    {
                        Console.WriteLine("one");
                    }
                    else if (n == 2)
                    {
                        Console.WriteLine("two");
                    }
                    if (n == 3)
                    {
                        Console.WriteLine("three");
                    }
                    else if (n == 4)
                    {
                        Console.WriteLine("four");
                    }
                    if (n == 5)
                    {
                        Console.WriteLine("five");
                    }
                    else if (n == 6)
                    {
                        Console.WriteLine("six");
                    }
                    if (n == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    else if (n == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    if (n == 9)
                    {
                        Console.WriteLine("nine");
                    }
                    else if (n == 10)
                    {
                        Console.WriteLine("ten");
                    }
                    if (n == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    else if (n == 12)
                    {
                        Console.WriteLine("twelve");
                    }
                    if (n == 13)
                    {
                        Console.WriteLine("thirteen");
                    }
                    else if (n == 14)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (n == 15)
                    {
                        Console.WriteLine("fifteen");
                    }
                    else if (n == 16)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (n == 17)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (n == 18)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (n == 19)
                    {
                        Console.WriteLine("nineteen");
                    }
                }
                else if (n < 100)
                {
                    int tens = n / 10;
                    int ones = n % 10;

                    if (tens == 2)
                    {
                        Console.Write("twenty");
                    }
                    else if (tens == 3)
                    {
                        Console.Write("thirty");
                    }
                    else if (tens == 4)
                    {
                        Console.Write("forty");
                    }
                    else if (tens == 5)
                    {
                        Console.Write("fifty");
                    }
                    else if (tens == 6)
                    {
                        Console.Write("sixty");
                    }
                    else if (tens == 7)
                    {
                        Console.Write("seventy");
                    }
                    else if (tens == 8)
                    {
                        Console.Write("eighty");
                    }
                    else if (tens == 9)
                    {
                        Console.Write("ninety");
                    }

                    if (ones == 0)
                    {
                        Console.WriteLine();
                    }
                    else if (ones == 1)
                    {
                        Console.WriteLine(" one");
                    }
                    else if (ones == 2)
                    {
                        Console.WriteLine(" two");
                    }
                    if (ones == 3)
                    {
                        Console.WriteLine(" three");
                    }
                    else if (ones == 4)
                    {
                        Console.WriteLine(" four");
                    }
                    if (ones == 5)
                    {
                        Console.WriteLine(" five");
                    }
                    else if (ones == 6)
                    {
                        Console.WriteLine(" six");
                    }
                    if (ones == 7)
                    {
                        Console.WriteLine(" seven");
                    }
                    else if (ones == 8)
                    {
                        Console.WriteLine(" eight");
                    }
                    if (ones == 9)
                    {
                        Console.WriteLine(" nine");
                    }


                }
                else if (n == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            
        }
    }
}
