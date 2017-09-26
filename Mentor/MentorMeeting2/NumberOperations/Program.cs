using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            
            switch (operation)
            {
                case '+':
                    Console.Write($"{n1} {operation} {n2} = {n1 + n2} - ");

                    if ((n1 + n2) % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    break;
                case '-':
                    Console.Write($"{n1} {operation} {n2} = {n1 - n2} - ");

                    if ((n1 - n2) % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {operation} {n2} = {(n1 * 1.0 / n2):f2}");
                    }
                    break;
                case '*':
                    Console.Write($"{n1} {operation} {n2} = {n1 * n2} - ");

                    if ((n1 * n2) % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} {operation} {n2} = {(n1 % n2)}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
