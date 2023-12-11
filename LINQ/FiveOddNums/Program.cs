namespace FiveOddNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(n => n % 2 != 0)
                .ToArray();
          List<int> list = new List<int>(nums);
            List <int>values = new List<int>(nums);
            for(int i  = 0; i < 5; i++)
            {
                int g = list.Max();

               Console.Write($"{g} ");

                list.Remove(g);
            }
            
        }
    }
}