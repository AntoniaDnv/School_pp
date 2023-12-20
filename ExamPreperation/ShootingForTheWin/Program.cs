namespace ShootingForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            
            int counter = 0;
           
            while ((command = Console.ReadLine()) != "End")
            {
                int n = int.Parse(command);

                if (n < 0 || n >= target.Length || target[n] == -1)
                {
                    continue;
                }

                int shotValue = target[n];
               
                target[n] = -1;
               
                counter++;

                for (int i = 0; i < target.Length; i++)
                {
                    
                    if (target[i] > shotValue)
                    {
                        target[i] -= shotValue;
                    }
                    else if (target[i] != -1)
                    {
                        target[i] += shotValue;
                    }
                }
            }
          
            Console.WriteLine($"Shot target: {counter} -> {string.Join(" ", target)}");
        }
    }
}