namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] splitting = { '\\', '.' };
            string[] fileextention = Console.ReadLine()
                .Split(splitting, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {fileextention[fileextention.Length-2]}");
            Console.WriteLine($"File extension: {fileextention[fileextention.Length - 1]}");
        }
    }
}