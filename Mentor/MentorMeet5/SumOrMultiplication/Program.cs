using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            bool hasResult = false;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i < j && j < k && i + j + k == controlNumber)
                        {
                            Console.WriteLine($"{i} + {j} + {k} = {i + j + k}");
                            hasResult = true;
                        }
                        else if (i > j && j > k && i * j * k == controlNumber)
                        {
                            Console.WriteLine($"{i} * {j} * {k} = {i * j * k}");
                            hasResult = true;
                        }
                    }
                }
            }

            if (!hasResult)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
