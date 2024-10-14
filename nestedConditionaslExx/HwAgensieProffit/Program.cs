using System;
namespace HwAgensieProffit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ticketsOldpeople = int.Parse(Console.ReadLine());
            int ticketsChildren = int.Parse(Console.ReadLine());
            double  ticketpriceMiddleaged = double.Parse(Console.ReadLine());
            double service = double.Parse(Console.ReadLine());
            double priceChildren = ticketpriceMiddleaged -ticketpriceMiddleaged * 0.70;
            double allMoney = (ticketsOldpeople * (ticketpriceMiddleaged + service)) + (ticketsChildren * (priceChildren + service));
            double profit = allMoney * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");



        }
    }
}