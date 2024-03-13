
    namespace stringText
    {
        internal class Program
        {
            static void Main(string[] args)
            {
               string word = Console.ReadLine();
                while(word != "end")
                {
                    string reverse = "";
                    for(int i = word.Length-1; i >= 0; i--)
                    {
                        reverse = reverse + word[i];
                    }
                    Console.WriteLine($"{word} = {reverse}");
                    word = Console.ReadLine();
                }
            }
        }
    }