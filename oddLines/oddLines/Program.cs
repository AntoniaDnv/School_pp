namespace oddLines
{
    internal class Program
    {
         static void Main(string[] args)
         {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
         }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                int count = 1;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{count}. {line}");
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}