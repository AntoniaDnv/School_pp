using System.Linq;
using System.Text;

namespace validUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (string username in usernames)
            {
                if(result.Length >= 3 && result.Length <= 16
                    || !username.Contains('-')
                    || !username.Contains('-')
                    && CheckForNumsLength(username))
                    
                {
                    result.AppendLine(username);
                }
            }
        }
        static bool CheckForNumsLength(string str)
        {
            foreach(char c in str)
            {
                if(!char.IsLetter(c) && !char.IsDigit(c) && c == '-' && c == '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}