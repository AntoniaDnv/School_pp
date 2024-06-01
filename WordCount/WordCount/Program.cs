namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string wordsPath = @"..\..\..\Files\words.txt";
           string textPath = @"..\..\..\Files\text.txt";
           string outputPath = @"..\..\..\Files\output.txt";

            string[] words = {wordsPath};
          WordCount wordCount = new WordCount();
        
        }
    }
    public class WordCount
    {
        public void CalculateWordCounts(string wordsPath, string textPath,
        string outputPath)
        {
            using(var reader = new StreamReader(wordsPath))
            {
                int count = 0;
                for (int i = 0; i <)
            }
           
        }
    }
}