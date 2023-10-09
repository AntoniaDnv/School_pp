using System.Diagnostics.CodeAnalysis;

namespace PrintPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int start = int.Parse(Console.ReadLine());
          int end = int.Parse(Console.ReadLine());
            char sum = ' ';
            for (int i = start; i <= end; i++)
            {
               
                Console.Write($"{(char)i} ");

            
               
            }
          
        }
    }
}