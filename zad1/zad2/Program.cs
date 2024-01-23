namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] steel = Console.ReadLine()
                 .Split()
                .Select(int.Parse)
                .ToArray();
            int[] carbon  = Console.ReadLine()
                 .Split()
                .Select(int.Parse)
                .ToArray();
           
            Queue<int> S = new Queue<int>(steel);
            Stack<int> C = new Stack<int>(carbon);
            Queue<int> SS = new Queue<int>(steel);
            Stack<int> CC = new Stack<int>(carbon);
            int swordCounter = 0;
            int totalS = 0;
            int totalC = 0;
            while (C.Count > 0 && S.Count > 0) 
            {
                
                int power = C.Peek() + S.Peek();
                switch (power)
                {
                    case 70:
                        swordCounter++;
                        Console.WriteLine("Gladius");
                        C.Pop();
                        S.Dequeue();
                        break;
                    case 80:
                        swordCounter++;
                        Console.WriteLine("Shamshir");
                        C.Pop();
                        S.Dequeue();
                        break;
                    case 90:
                        swordCounter++;
                        Console.WriteLine("Katana");
                        C.Pop();
                        S.Dequeue();
                        break;
                    case 110:
                        swordCounter++;
                        Console.WriteLine("Sabre");
                        C.Pop();
                        S.Dequeue();
                        break;
                    case 150:
                        swordCounter++;
                        Console.WriteLine("Broadsword");
                        C.Pop();
                        S.Dequeue();
                        break;
                    default:
                        S.Dequeue();
                       
                       
                        int temp = C.Pop() + 5;
                        C.Push(temp);
                        break;
                }


            }
           
            if(swordCounter == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {swordCounter} swords.");
            }
           
            Console.WriteLine($"Steel left: {S.Sum()}");
            Console.WriteLine($"Carbon left: {C.Sum()}");
        }
    }
}