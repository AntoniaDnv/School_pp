using System.Text.RegularExpressions;

namespace testJsonToCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string userInputValidator = @"^(?<path>[\w/]+)/$";

            Match match = Regex.Match(userInput, userInputValidator);

            if (match.Success)
            {
                string path = match.Groups["path"].Value;
                Console.WriteLine($"Valid path: {path}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}