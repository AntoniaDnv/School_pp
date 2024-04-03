using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace runningGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"<>(?<name>\w+)<>(?<quantity>\d+)--(?<price>\d+.?(\d+)?)";
            double total= 0;
            Regex regex = new Regex(pattern);
            
            while (input.ToLower() != "run!")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Match matchM = Regex.Match(input, pattern);
                    string gear = matchM.Groups["name"].Value;
                    int quantity = int.Parse(matchM.Groups["quantity"].Value);
                    double money = double.Parse(matchM.Groups["price"].Value);
                   
                    Console.WriteLine($"{gear}");  
                    
                    total += money*quantity;
                }
                 input = Console.ReadLine();
            }
            Console.WriteLine("Gear bought:");
            Console.WriteLine($"Total cost: {total:f2}");
        }
    }
}