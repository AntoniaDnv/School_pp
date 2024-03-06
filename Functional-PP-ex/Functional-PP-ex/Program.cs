using System;
using System.Linq;

namespace Functional_PP_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                switch (commands)
                {
                    case "add":
                        ApplyFunction(nums, x => x + 1);
                        break;
                    case "multiply":
                        ApplyFunction(nums, x => x * 2);
                        break;
                    case "subtract":
                        ApplyFunction(nums, x => x - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                }
                commands = Console.ReadLine();
            }
        }

        static void ApplyFunction(int[] array, Func<int, int> func)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = func(array[i]);
            }
        }
    }
}
