﻿namespace sumNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int[] nums = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}