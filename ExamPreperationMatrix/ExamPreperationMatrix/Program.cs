namespace ExamPreperationMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactionsPerH = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int tasks = int.Parse(Console.ReadLine());
            int workingH = 0;
            int a = 0;
            int totalWorkH = 0;
            for(int j = 0; j < transactionsPerH.Length; j++)
            {
                totalWorkH = totalWorkH + transactionsPerH[j];   
            }
           
            for(int i = 0; i < tasks; i = 0)
            {
                a++;
                workingH++;
                if (workingH == 4)
                {   a++;
                    workingH = 0;
                   
                }

                    tasks = tasks - totalWorkH;

               
            }
            Console.WriteLine($"Time needed: {a}h.");
        }
    }
}