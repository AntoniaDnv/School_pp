namespace cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string film = Console.ReadLine();
         string packet = Console.ReadLine();    
         int tickets = int.Parse(Console.ReadLine());
            double cost = 0;
            double total = 0;

            if (film == "The matrix")
            {
                switch (packet)
                {
                    case "Drink":
                        cost = 12; break;
                    case "Popcorn":
                        cost = 15; break;
                    case "Nachos":
                        cost = 19;
                        break;
                }
            }
            if (film == "Oppenheimer")
            {
                switch (packet)
                {
                    case "Drink":
                        cost = 18; break;
                    case "Popcorn":
                        cost = 25; break;
                    case "Nachos":
                        cost = 30;
                        break;
                }
            }
            if (film == "Barbie")
            {
                switch (packet)
                {
                    case "Drink":
                        cost = 9; break;
                    case "Popcorn":
                        cost = 11; break;
                    case "Nachos":
                        cost = 14;
                        break;
                }
            }
            total = cost * tickets;

            if (film =="Oppenheimer" && tickets >= 6)
            {
                total = total - total * 0.3;
            }

            if (film =="Barbie" && tickets == 4)
            {
                total = total - total * 0.15;
            }
            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}