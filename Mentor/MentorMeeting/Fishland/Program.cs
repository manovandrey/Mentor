using System;


namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mackerelPrice = decimal.Parse(Console.ReadLine());
            decimal spratPrice = decimal.Parse(Console.ReadLine());
            decimal palmwoodKilograms = decimal.Parse(Console.ReadLine());
            decimal scadKilograms = decimal.Parse(Console.ReadLine());
            decimal shellfishKilograms = decimal.Parse(Console.ReadLine());
            
            decimal palmwoodPrice = mackerelPrice + (mackerelPrice * 60) / 100;
            decimal scadPrice = spratPrice + (spratPrice * 80) / 100;
            
            decimal palmwoodSum = palmwoodPrice * palmwoodKilograms;
            decimal scadSum = scadPrice * scadKilograms;
            decimal shellfishSum = shellfishKilograms * 7.5m;
            
            decimal result = palmwoodSum + scadSum + shellfishSum;

            Console.WriteLine("{0:f2}", result, 2);


        }
    }
}
