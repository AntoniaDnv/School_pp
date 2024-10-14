namespace BusTicketsProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string busCompanyName = Console.ReadLine();
            double numTicketsAdult = double.Parse(Console.ReadLine());
            double kidTickets = double.Parse(Console.ReadLine());
            double adultPrice = double.Parse(Console.ReadLine());
            double kidPrice = adultPrice * 0.6;
            double tax = double.Parse(Console.ReadLine());

            double totalAdult =( adultPrice + tax)* numTicketsAdult ;
            double totalKid = (kidPrice + tax) * kidTickets;
            double profit = 0.25 * (totalAdult+ totalKid) ;
            Console.WriteLine($"The profit of your agency from{busCompanyName} tickets is {profit:f2}lv.");
        }
    }
}