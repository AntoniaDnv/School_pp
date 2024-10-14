using System;
namespace filmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packedge = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;
            
            switch (movie)
            {
                case "John Wick":
                    switch (packedge)
                    {
                        case "Drink": 
                            price = 12;
                            break;
                        case "Popcorn":
                            price = 15;
                            break;
                        case "Menu": 
                            price = 19; 
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (packedge)
                    {
                        case "Drink": 
                            price = 18;
                            break;
                        case "Popcorn": 
                            price = 25; 
                            break;
                        case "Menu":
                            price = 30; 
                            break;
                    }
                    break;
                case "Jumanji":
                    switch (packedge)
                    {
                        case "Drink": 
                            price = 9;
                            break;
                        case "Popcorn":
                            price = 11;
                            break;
                        case "Menu":
                            price = 14; 
                            break;
                    }
                    break;
            }

            double totalPrice = tickets * price;
             if (movie == "Jumanji" && tickets == 2)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (movie == "Star Wars" && tickets >= 4)
            {
                totalPrice = totalPrice - 0.3 * totalPrice; 
            }
             Console.WriteLine($"Your bill is {totalPrice:F2} leva.");
        }
    }
}