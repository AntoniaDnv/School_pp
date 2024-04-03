using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace regexExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[>]{2}(?<fur>\w+?\s?\w+)[<]{2}(?<price>(\d?.?\d)+)[!](?<quantity>\d+)");
           
            double total = 0;
            List<string> furniture = new List<string>();
            string input = Console.ReadLine();
          
            while (input.ToLower() != "purchase")
            {
                bool match = regex.IsMatch(input);
                if(match == true)
                {
                    Match match1 = regex.Match(input);
                    string fur = match1.Groups["fur"].Value;
                    double price = double.Parse(match1.Groups["price"].Value);
                    double quantity = double.Parse(match1.Groups["quantity"].Value);
                    total += quantity* price;
                    furniture.Add(fur);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach(string furnitures in furniture)
            {
                Console.WriteLine(furnitures);
            }
            Console.WriteLine("Total money spent:");
            Console.WriteLine(total);
        }
    }
}