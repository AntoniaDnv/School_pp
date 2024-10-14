
using System;
namespace HWaddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
         double above20 = double.Parse(Console.ReadLine());
         double lugadgeKg = double.Parse(Console.ReadLine());
         int daysTillFlight = int.Parse(Console.ReadLine());
         int numBags = int.Parse(Console.ReadLine());
         double taxes = 0;
         double endTaxes = 0;
            if (lugadgeKg < 10) 
            {
             taxes = 0.2 * above20;
            }
            else if (lugadgeKg >= 10 && lugadgeKg<=20) 
            {
                taxes = 0.5 * above20;
            }
            else if (lugadgeKg > 20)
            {
                taxes = above20;
            }

            if (daysTillFlight > 30)
            {
                endTaxes = taxes + taxes * 0.1;
            }
            else if (daysTillFlight <=30 && daysTillFlight >=7) 
            {
                endTaxes = taxes + taxes * 0.15;
            }
            else if ( daysTillFlight < 7)
            {
                endTaxes = taxes + taxes * 0.4;
            }
            Console.WriteLine($" The total price of bags is: {(endTaxes*numBags):f2} lv. ");
        }
    }
}