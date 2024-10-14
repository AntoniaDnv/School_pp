using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double neededMoney = double.Parse(Console.ReadLine());
           double moneyWeHave = double.Parse(Console.ReadLine());
            double counter = 0;
            double counterAllDays = 0;
           
           while (true)
            {
                string saveSpend = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                if (saveSpend == "save")
                {
                    moneyWeHave += amount;
                    counter = 0;
                    counterAllDays++;
                }
                else if (saveSpend == "spend")
                {
                    if(moneyWeHave< amount)
                    {
                        moneyWeHave = 0;
                    }
                    else { moneyWeHave -= amount;}
                    
                    counter++;
                    counterAllDays++;
                }
                if (counter==5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(counter);
                    break;
                }
                if (moneyWeHave>= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {counterAllDays} days.");
                    break;
                }

            }
        }
    }
}