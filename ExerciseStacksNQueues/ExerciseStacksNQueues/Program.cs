namespace ExerciseStacksNQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                
                    while (lift[i] != 4&& n > 0)
                    {
                        n--;
                        lift[i]++;
                        

                    }

                

            }

            if (lift[lift.Length-1] !=    4 && n==0)
            {
                int[] arry = lift.Where(x => x < 4).ToArray();
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
                return;
            }
            else if (lift[lift.Length - 1] == 4 &&  n > 0)
            {
                Console.WriteLine($"There isn't enough space! {n} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));

            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }

          
               
            


        }
    }
}