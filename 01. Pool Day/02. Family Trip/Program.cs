using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int nosht = int.Parse(Console.ReadLine());
            double priceNosht = double.Parse(Console.ReadLine());   
            double procentRazhodi = double.Parse(Console.ReadLine());
            if (8 > 7)
            {
                double discount = priceNosht * 0.05;
                double price = priceNosht - discount;
                double priceDiscount = nosht * price;
                double dopulni = budjet * 0.02;
                double total = priceDiscount + dopulni;
                double totalDiscount = budjet - total;
                Console.WriteLine($"{Math.Ceiling(totalDiscount):F2} leva needed.");
            }
            else
            {
                double price = nosht * priceNosht;
                double discount = budjet * 0.15;
                double total = price + discount;
                double totalDiscount = budjet - total;
                Console.WriteLine($"Ivanovi will be left with {Math.Abs(totalDiscount):F2} leva after vacation.");
            }
        }
    }
}
