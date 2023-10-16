namespace MaxSeqOfEqualEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = 0;  

           for(int i  = 0; i < nums.Length; i++) 
            { 
                for(int j  = nums[2]; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        count++;
                        Console.Write($"{j} ");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}