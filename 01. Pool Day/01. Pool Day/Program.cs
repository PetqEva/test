using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double priceOneFor = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());


            double entrance = numberOfPeople * entranceFee;  
            double deckChair = Math.Ceiling(numberOfPeople * 0.75);
            double umbrella = Math.Ceiling(numberOfPeople * 0.50);
            double totalPrice = entrance + deckChair * priceOneFor + umbrella * priceForOneUmbrella;
            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
