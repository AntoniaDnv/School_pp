using System.Diagnostics.CodeAnalysis;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();
            int matrixRow = size[0];
            int matrixColumn = size[1];
            int[,] matrix = new int[matrixRow, matrixColumn];
            int sum = 0;

            for(int row = 0; row< matrix.GetLength(0); row++)
            {
                int[] element = Console.ReadLine()
                     .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for(int col = 0; col< matrix.Length; col++)
                {
                    matrix[row, col] = element[col];
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(matrixRow);
            Console.WriteLine(matrixColumn);
            Console.WriteLine(sum);
        }
    }
}