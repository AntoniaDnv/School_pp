using System;
namespace movieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPr = int.Parse(Console.ReadLine());
            double endIncome = 0;
            double income = days*tickets*ticketPrice;
            endIncome = income - (income * cinemaPr / 100);
            Console.WriteLine($"The profit from the movie {name} is {endIncome:f2} lv.");
        }
    }
}