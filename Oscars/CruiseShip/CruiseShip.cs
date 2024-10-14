namespace CruiseShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string cruiseType = Console.ReadLine();
           string cabin = Console.ReadLine();
           int nights = int.Parse(Console.ReadLine());
           double priceOfcabin = 0;
           double priceOfTrip = 0;
           double endPrice = 0;

            switch (cruiseType)
            {
                case "Mediterranean":
                   if (cabin == "standard cabin")
                    {
                        priceOfcabin = 27.50;
                    } 
                   else if (cabin == "cabin with balcony")
                    {
                        priceOfcabin = 30.20;
                    }
                   else if(cabin == "apartment")
                    {
                        priceOfcabin = 40.50;
                    }
                    break;
                case "Adriatic":
                   
                    if (cabin == "standard cabin")
                    {
                        priceOfcabin = 22.99;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        priceOfcabin = 25.00;
                    }
                    else if (cabin == "apartment")
                    {
                        priceOfcabin = 34.99;
                    }
                   
                    break;
                case "Aegean":
                    if (cabin == "standard cabin")
                    {
                        priceOfcabin = 23.00;
                    }
                    else if (cabin == "cabin with balcony")
                    {
                        priceOfcabin = 26.60;
                    }
                    else if (cabin == "apartment")
                    {
                        priceOfcabin = 39.80;
                    }
                    break;
            }
            priceOfTrip = priceOfcabin * 4 * nights;

            if (nights > 7)
            {
                endPrice = priceOfTrip - priceOfTrip * 0.25;

            }
            else if(nights <= 7)
            {
                endPrice = priceOfTrip;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {endPrice:f2} lv.");
        }
    }
}