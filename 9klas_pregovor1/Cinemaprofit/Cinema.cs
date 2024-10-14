namespace Cinemaprofit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int numTickets = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double procent= double.Parse(Console.ReadLine())/100;
      

            double allMoney = days * (numTickets * price);
            double endMoney = allMoney * (1 - procent);

            Console.WriteLine($"The profit from {name} is {endMoney:f2} lv.");
        }
    }
}