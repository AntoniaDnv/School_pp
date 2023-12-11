namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for(int i =0; i < nums.Length; i++)
            {
               
                if (nums[i]%2==0)
                {
                    Console.WriteLine($"{nums[i]} is odd - False");
                }
                else
                {
                    Console.WriteLine($"{nums[i]} is odd - True");
                }
            }
        }
    }
}