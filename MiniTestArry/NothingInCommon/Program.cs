using System.Globalization;

namespace NothingInCommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = (Console.ReadLine())
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());  

            for(int i = 0; i < arry.Length; i++)
            {
                for(int j = i+1; j<arry.Length; j++)
                {
                    if (arry[i] + arry[j] == n)
                    {
                        Console.WriteLine($"{arry[i]} {arry[j]}");
                    }
                }
            }
        }
    }
}