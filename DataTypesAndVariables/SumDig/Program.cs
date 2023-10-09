namespace SumDig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
          
            int sum = 0;
            foreach (int number in numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
              
            }

         
            Console.WriteLine(sum);

        }
    }
}