﻿namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());

                totalSum += nums;

                if (nums > max)
                {
                    max = nums;
                }
            }

                int sumWhithoutMax = totalSum - max;
                if(sumWhithoutMax == max)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {max}");

                }
                else
                {
                    int diff = Math.Abs(max- sumWhithoutMax);
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {diff}");
                }


            
        }
    }
}