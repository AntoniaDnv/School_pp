using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the phone number from the console input
            var phoneNum = Console.ReadLine();

            // Define the regex pattern for matching phone numbers
            var pattern = @"\+359\s\d{2}[\s-]?\d{3}[\s-]?\d{4}";

            // Create a Regex object with the specified pattern
            Regex regex = new Regex(pattern);

            // Match the phone number against the regex pattern
            MatchCollection validNames = regex.Matches(phoneNum);

            // Extract matched phone numbers as an array of strings
            var matchedPhones = validNames
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            // Display the matched phone numbers separated by commas
            Console.Write(string.Join(",", matchedPhones));
        }
    }
}