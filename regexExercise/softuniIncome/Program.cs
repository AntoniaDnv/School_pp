using System.Text.RegularExpressions;

namespace softuniIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            double totalIncome = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {

                string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);


                    double totalPrice = count * price;

                    totalIncome += totalPrice;


                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
                }
            }


            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}