using System;
namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int saved = 0;
            while (destination != "End")
            {
                int moneyNeeded = int.Parse(Console.ReadLine());

                while (saved < moneyNeeded)
                {
                    saved += int.Parse(Console.ReadLine());
                    if (saved >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        saved = 0;
                        destination = Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}