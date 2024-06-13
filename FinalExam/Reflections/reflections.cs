
    using System.Text.RegularExpressions;

    namespace Reflections
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string regexOne = @"([@|#]){1,2}(?<word1>[A-z]{3,})\1{2}(?<word2>[A-z]{3,})\1";
                Regex regex = new Regex(regexOne);
                string input = Console.ReadLine();
                int count = 0;
                MatchCollection matches = regex.Matches(input);
                List<string> wordPairs = new List<string>();
                List<string> mirrorPairs = new List<string>();
                foreach (Match match in matches)
                {
               
                    string word1 = match.Groups["word1"].Value;
                    string word2 = match.Groups["word2"].Value;
                    wordPairs.Add(($"{word1} <=> {word2}"));
                    count++;
                    string reverse = "";
                    for (int i = 0; i < word1.Length; i++)
                    {
                        reverse = reverse + word1[word1.Length-i-1];
                    }
                    if(reverse == word2)
                    {
                    
                        mirrorPairs.Add($"{word1} <=> {word2}");
                    }
                }
                if(wordPairs.Count <= 0)
                {
                    Console.WriteLine("No word pairs found!");
                }
                else
                {
                    Console.WriteLine($"{wordPairs.Count} word pairs found!");
                }
            
                if( mirrorPairs.Count <= 0 )
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorPairs));
                }

            }

        }
    }