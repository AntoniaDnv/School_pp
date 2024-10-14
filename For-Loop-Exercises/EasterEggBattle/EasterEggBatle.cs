using System;

namespace EasterEggBattle
{
    internal class EasterEggBatle
    {
        static void Main(string[] args)
        {
            double eggsOne = double.Parse(Console.ReadLine());
            double eggsTwo = double.Parse(Console.ReadLine());
            

            for (double i = 0; i < eggsOne && i < eggsTwo; i=i )
            {
                string winner = Console.ReadLine();
               switch(winner)
                {
                    case "one":
                        eggsTwo = eggsTwo - 1;
                        break;
                        case "two":
                        eggsOne = eggsOne - 1;
                        break;
                    case "End":
                        i = eggsOne;
                        break;
                }
                
            }
            if (eggsOne > eggsTwo) 
            {
               double leftEggs = eggsOne - eggsTwo;
                Console.WriteLine($"Player two is out of eggs. Player one has {leftEggs} eggs left.");
            }
            else if ( eggsOne < eggsTwo) 
            {
             double lefteggs = eggsTwo - eggsOne;
                Console.WriteLine($"Player one is out of eggs. Player two has {lefteggs} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one has {eggsOne} eggs left.");
                Console.WriteLine($"Player two has {eggsTwo} eggs left.");
            }

        }
    }
}