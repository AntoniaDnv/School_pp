namespace zad2
{
    internal class zad2
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string colour = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double price = 0;
            switch(size)
            {
                case "Large":
                    if (colour == "Red")
                    {
                        price = 116;
                    }   
                    else if (colour == "Green")
                    {
                        price = 112;
                    }
                    else if(colour == "Yellow")
                    {
                        price = 109;
                    }
                    break;

                case "Medium":
                    if (colour == "Red")
                    {
                        price = 83;
                    }
                    else if (colour == "Green")
                    {
                        price = 89;
                    }
                    else if (colour == "Yellow")
                    {
                        price = 87;
                    }
                    break;
                
                case "Small":
                    if (colour == "Red")
                    {
                        price = 49;
                    }
                    else if (colour == "Green")
                    {
                        price = 48;
                    }
                    else if (colour == "Yellow")
                    {
                        price = 45;
                    }
                    break;

               
            }
            double allMoney = price * sales;
            double endMOney = allMoney - 0.35 * allMoney;

            Console.WriteLine($"{endMOney} leva.");
        }
    }
}