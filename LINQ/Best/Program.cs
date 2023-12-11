namespace Best
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()

                  .Split()

                .Where(n => n.Contains("est"))
                  .Where(n => n.Contains('b'))
                 

                  .ToArray();
           
            if(words.Length > 0)
            {
                string first = words[0];
                string second = words[words.Length - 1];
                first = first.ToUpper();
                second = second.ToUpper();
                Console.WriteLine($"First best word: {first}");
                Console.WriteLine($"Last best word: {second}");

            }
            else
            {
                return;
            }
           
        }
    }
}