namespace CinemaIncom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string room = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;

            if (name == "Barbie")
            {
                switch (room)
                {
                    case "normal":
                        price = 7.50;
                        break;

                    case "luxury":
                        price = 10.50;
                        break;

                    case "ultra luxury":
                        price = 13.50;
                        break;
                }
            }
            else if (name == "Oppenheimer")
            {
                switch (room)
                {
                    case "normal":
                        price = 7.35;
                        break;

                    case "luxury":
                        price = 9.45;
                        break;

                    case "ultra luxury":
                        price = 12.75;
                        break;
                }
            }
            else if (name == "Green Book")
            {
                switch (room) 
                {
                    case "normal":
                        price = 8.15;
                        break;

                    case "luxury":
                        price = 10.25;
                        break;

                    case "ultra luxury":
                        price = 13.25;
                        break;
                }
            }
            else if(name =="The Future")
            {
                switch (room)
                {
                    case "normal":
                        price = 8.75;
                        break;

                    case "luxury":
                        price = 11.55;
                        break;

                    case "ultra luxury":
                        price = 13.95;
                        break;
                }
            }
            double allMoney = price * tickets;

            Console.WriteLine($"{name} made {allMoney} lv.");
        }
    }
}