using System.Runtime.Serialization.Formatters;

namespace zad2_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                set.Add(a);
            }
            foreach(string a in set)
            {
                Console.WriteLine(a);
            }
        }
    }
}