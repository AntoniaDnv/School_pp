namespace Vhodno2srok10klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Customer customer = new Customer(int.Parse(input[0]),
               input[1], int.Parse(input[2]), input[3] );

            string[] command = Console.ReadLine().Split();    
            
            while (command[0] != "End") 
            {
                if (command[0] == "Bonus" && command[1] == "Points")
                {
                    customer.AddBonusPoints(int.Parse(command[2]));
                }
                if (command[0] == "Exchange")
                {
                    customer.ExchangePoints(int.Parse(command[1]));
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
