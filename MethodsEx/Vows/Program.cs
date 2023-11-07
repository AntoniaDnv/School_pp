using System.Diagnostics.Metrics;

namespace Vows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = 0;
            CheckVows( word,  counter);
        }
        static void CheckVows(string word, int counter)
        {
            foreach (char c in word)
            {
                if (c ==  'a' || c == 'A' || c == 'o'|| c == 'O' || c == 'u' || c == 'U'||c == 'e' || c == 'E' || c == 'i' || c == 'I')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}