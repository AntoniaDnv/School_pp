using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfNames = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+[\s]{1}[A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(listOfNames);

            foreach (Match name in validNames)

            {

                Console.Write($"{name.Value}" + "\n");

            }
        }
    }
}