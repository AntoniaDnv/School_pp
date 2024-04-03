using System.Text.RegularExpressions;

namespace emailExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();


            string pattern = @"\b[A-Za-z0-9]+(?:[_\-\.][A-Za-z0-9]+)*@[A-Za-z0-9]+(?:[A-Za-z\-][A-Za-z0-9]+)*\.[A-Za-z]{2,}(?:\.[A-Za-z]{2,})?\b";


            Regex regex = new Regex(pattern);


            MatchCollection matches = regex.Matches(text);


            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}