namespace MiddleCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine()
                .ToArray ();
                double n = word.Length;
                if(n%2 ==0)
                {
                GetMiddIfEven(word);
            }
                else
                {
                GetMiddIfOdd(word);

                }
                
        }

        static void GetMiddIfOdd(char[] word)
        {
        
            int m = word.Length / 2;

            Console.WriteLine(word[m]);
        }

        static void GetMiddIfEven(char[] word)
        {
            int m = word.Length / 2;
            Console.WriteLine($"{word[m-1]}{word[m]}");
        }
    }

}