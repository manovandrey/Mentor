using System;


namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            if ((x > 1 * h && x < 2 * h) && (y < 4 * h && y > 1 * h) ||
                (x > 0 && x < 3 * h) && (y < 1 * h && y > 0) || (x > 1 * h && x < 2 * h && y == h))
            {
                Console.WriteLine("inside");
            }
            else if ((y == 4 * h && (x >= 1 * h && x <= 2 * h)) ||
                (y <= 4 * h && y >= 1 * h && x == 2 * h) || 
                (x >= 2 *h && x <= 3 * h && y == 1 * h) ||
                (x == 3 * h && y <= 1 * h && y >= 0) ||
                (y == 0 && x >= 0 && x <= 3 * h) ||
                (y >= 0 && y <= 1 * h && x == 0 ) ||
                (y == h && x >= 0 && x <= h) ||
                (x == 1 * h && y >= 1 * h && y <= 4 * h))
                
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
