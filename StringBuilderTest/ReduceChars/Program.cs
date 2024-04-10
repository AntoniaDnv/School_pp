using System.Text;

namespace ReduceChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string vowls = "aeiou";
            List<char> chek = new List<char>();
           foreach (char ch in vowls)
            {
                chek.Add(ch);
            }
            StringBuilder output = new StringBuilder();

            foreach(char a in input)
            {
                if (!chek.Contains(a))
                {
                    output.Append(a);
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}