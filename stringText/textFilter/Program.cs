using System.Text;

namespace textFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bandWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var bandWord in bandWords)
            {
                if (text.Contains(bandWord))
                {
                    text = text.Replace(bandWord, new string('*', bandWord.Length));
                }

            }
            Console.WriteLine(text);
        }
    }
}