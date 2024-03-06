
namespace miniexam_SetsandDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();
                if (!set.Contains(names))
                {
                    set.Add(names);
                }
               
            }

            foreach(string kvp in  set)
            {
                Console.WriteLine($"{kvp}");
            }
        }
    }
}