using System;

namespace zadOtRAbotaVKlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<double> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse) 
                .ToList();

            Console.WriteLine(Priting(nums));
        }
        static string Priting(List<double> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    break;
                }
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i = -1;
                }
            }
            string result = string.Join(" ", nums);
            return result;
        }
    }
}