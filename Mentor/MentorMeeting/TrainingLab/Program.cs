using System;


namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wInCentimiters = w * 100;
            double hInCentimiters = h * 100;

            hInCentimiters -= 100;

            double rows = Math.Floor(wInCentimiters / 120);
            double cols = Math.Floor(hInCentimiters / 70);

            double result = rows * cols - 3;

            Console.WriteLine(result);

        }
    }
}
