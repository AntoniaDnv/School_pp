using System.Xml.Schema;

namespace dogWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int minWalk = int.Parse(Console.ReadLine());
          int walks = int.Parse(Console.ReadLine());    
          int calories = int.Parse(Console.ReadLine());

          int totalLostCal = minWalk * walks *10;
            double calCount = 0.4 * calories;

            if (calCount <=totalLostCal)
            {
                Console.WriteLine($"The walk for your dog is enough. Burned calories per day: {totalLostCal}.");
            }
            else
            {
                Console.WriteLine($"The walk for your dog is not enough. Burned calories per day: {totalLostCal}.");
            }
          
        }
    }
}