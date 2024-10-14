
using System;
namespace nestedCondittionalStatmentsHomeWork

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;
            double price1 = 0;
            double endPrice = 0;
            if (size == "small")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 56 * 2; break;
                    case "Mango":
                        price = 36.66 * 2;
                        break;
                    case "Pineapple":
                        price = 42.10 * 2;
                        break;
                    case "Raspberry":
                        price = 20 * 2;
                        break;

                }
            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 28.70 * 5; break;
                    case "Mango":
                        price = 19.60 * 5;
                        break;
                    case "Pineaple":
                        price = 24.80 * 5;
                        break;
                    case "Raspberry":
                        price = 15.20 * 5;
                        break;
                }
            }
            price1 = price * count;

            if (price1 >= 400 && price1 <= 1000)
            {
                endPrice = price1 - (price1 * 0.15);
            }
            else if (price1 >= 1000)
            {
                endPrice = price1 / 2;
            }
            else
            {
                endPrice = price1;
            }
            Console.WriteLine($"{endPrice:f2} lv.");
        }
    }
}