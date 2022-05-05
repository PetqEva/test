using System;

namespace Oskari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());
            double statuetki = naem - naem * 0.30;
            double ketaring = statuetki - statuetki * 0.15;
            double ozvuchavane = ketaring * 0.50;
            double sum = naem + statuetki + ketaring + ozvuchavane;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
