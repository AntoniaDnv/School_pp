using System.Text;

namespace CeaserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char letter in message)
            {
                char c = (char)(letter+3);
                stringBuilder.Append(c);
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}