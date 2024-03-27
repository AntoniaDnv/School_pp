using System.Text.RegularExpressions;

namespace MatchPhoneNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

        
            var pattern = @"+359([-])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phoneNum = Console.ReadLine();

            

            MatchCollection phoneMatch = Regex.Matches(phoneNum, pattern);
        
            var matchedPhones = phoneMatch 
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
          
           

                Console.Write(string.Join(",", matchedPhones));

        
        }
    }
}