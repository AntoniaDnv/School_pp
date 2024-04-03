
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace testRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stuf = Console.ReadLine();
            var patternM = @"[@](?<metal>\w+)[|]";
            var patternG = @"[#](?<gem>\w+)[*]";
            Regex regexM = new Regex(patternM);
            Regex regexG = new Regex(patternG);
            MatchCollection matchesM = regexM.Matches(stuf);
            MatchCollection matchesG = regexM.Matches(stuf);
            
            Match matchM = Regex.Match(stuf, patternM);
            string metal = matchM.Groups["metal"].Value;
           
            Match matchG = Regex.Match(stuf, patternG);
            string gems = matchG.Groups["gem"].Value;
           
            Console.WriteLine($"Found hidden {metal} and {gems} in the cave.");

        }
    }
}