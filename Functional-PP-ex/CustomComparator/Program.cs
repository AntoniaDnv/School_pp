using System.Collections.Immutable;

namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums);
            List<int> sorted = new List<int>();
            Func<int,bool> func = x => x % 2 == 0; 
            foreach (int n in nums)
            {
                if (func(n))
                {
                    sorted.Add(n);
                }
            }
            foreach (int n in nums)
            {
                if (!func(n))
                {
                    sorted.Add(n);
                }
            }
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}