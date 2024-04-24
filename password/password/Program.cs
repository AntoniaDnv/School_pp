using System.Text.RegularExpressions;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"[a-zA-Z\d-]+");
            Match pass = regex.Match(input);
            if(pass.ToString().Length >= 8 && pass.ToString().Length <= 16 && regex.IsMatch(pass.ToString()))
            {
                Console.WriteLine("Ok");
                Console.WriteLine(pass.ToString());
            }
            else
            {
                Console.WriteLine("Password's legth should be between 8-16 and contain only letters, numbers and -");
            }

        }
    }
}