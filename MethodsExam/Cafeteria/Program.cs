namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string product = Console.ReadLine();
         int quantity = int.Parse(Console.ReadLine());

            GetTotal(product, quantity);
        }
        static void GetTotal(string product, int quantity)
        {
            double total = 0;
            switch(product)
            {
                case "water":
                
                    total = quantity * 1;
                    
                    break;

               
                case "coke":
                
                    total = quantity * 1.4;
                    
                    break;
               
                case "coffee":
                
                    total = quantity * 1.5; 
                    
                    break;
               
                case "snacks":
                   
                    total = quantity * 2;
                    
                    break;

            }
            Console.WriteLine($"{total:f2}");
        }
    }
}