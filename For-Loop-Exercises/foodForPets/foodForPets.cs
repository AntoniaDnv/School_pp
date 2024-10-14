
using System;
namespace foodForPets
{
    internal class foodForPets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double allDogFoodEaten = 0;
            double allCatFoodEaten = 0;
            double foodEaten = 0;
            double foodEatenP = 0;
            double totalCookies = 0;
            double totalDogEatenP = 0;
            double totalCatEatenP = 0;
            for (int i = 1; i <= days; i++)
            {
                int dogAte = int.Parse(Console.ReadLine());
                int catAte = int.Parse(Console.ReadLine());

                allDogFoodEaten += dogAte;
                allCatFoodEaten += catAte;

                if (i % 3 == 0)
                {
                    totalCookies = totalCookies + (dogAte * 0.1) + (catAte * 0.1);
                }

            }
            foodEaten = (allCatFoodEaten + allDogFoodEaten);
            foodEatenP = foodEaten / food * 100;
            totalDogEatenP = allDogFoodEaten / foodEaten * 100;
            totalCatEatenP = allCatFoodEaten / foodEaten * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalCookies)}gr.");
            Console.WriteLine($"{foodEatenP:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogEatenP:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatEatenP:f2}% eaten from the cat.");
        }
    }
}