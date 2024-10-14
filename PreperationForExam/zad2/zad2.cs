namespace zad2
{
    internal class zad2
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double price = 0;
            switch (destination.ToLower())
            {
                case "germany":
                    if(dates == "21-23")
                    {
                        price = 32*nights;
                    }
                    else if(dates == "24-27")
                    {
                        price = 37 * nights;
                    }
                    else if (dates == "38-31")
                    {
                        price = 43 * nights;
                    }
                    
                    break;
                case "italy":
                    if (dates == "21-23")
                    {
                        price = 28 * nights;
                    }
                    else if (dates == "24-27")
                    {
                        price = 32 * nights;
                    }
                    else if (dates == "38-31")
                    {
                        price = 49 * nights;
                    }

                    break;
                case "france":
                    if (dates == "21-23")
                    {
                        price = 30 * nights;
                    }
                    else if (dates == "24-27")
                    {
                        price = 35 * nights;
                    }
                    else if (dates == "28-31")
                    {
                        price = 40 * nights;
                    }


                    break;

            }
            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
          

        }
    }
}