using System.Threading;

namespace periodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var table = new SortedDictionary<string, int>();

            for(int i = 0; i < num; i++)
            {
                string[] chemicals = Console.ReadLine().Split(" ");

                for(int j = 0; j < chemicals.Length; j++)
                {
                    if (!table.ContainsKey(chemicals[j]))
                    {
                        table.Add(chemicals[j], j);
                    }
                }
            }

            foreach (var kvp in table)
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}