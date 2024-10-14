namespace CoffeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coffe = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());
            double cost = 0;
            double total = 0;

            if (coffe == "Frappe")
            {
                switch(sugar)
                {
                    case "Without":
                        cost = 3.90;
                        break;
                    case "Normal":
                        cost = 4;
                        break;
                    case "Extra":
                        cost= 4.20;
                        break;
                }
            }
            else if (coffe == "Americano")
            {
                switch(sugar)
                {
                    case "Without":
                        cost = 0.90;
                        break;
                    case "Normal":
                        cost = 1;
                        break;
                    case "Extra":
                        cost = 1.10;
                        break;
                }
            }
            else if (coffe == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        cost = 2;
                        break;
                    case "Normal":
                        cost = 2.20;
                        break;
                    case "Extra":
                        cost = 2.60;
                        break;
                }
            }

            total = cost * numDrinks;

            if (numDrinks > 3 && sugar=="Without")
            {
               total= numDrinks * cost -(numDrinks*cost *0.10);
                

            }
            if (coffe=="Cappuccino" && numDrinks > 4)
            {
                total = numDrinks * cost - (numDrinks * cost * 0.25);

            }
            if (total > 20)
            {
                total = total - total*0.3;
            }
            Console.WriteLine($"{numDrinks} x {coffe} - {total:f2} lv.");
        }
    }
}