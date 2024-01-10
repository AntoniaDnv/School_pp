
namespace MultiDimentionalArry
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

            for(int row = 0; row< matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                     .Split(", ")
                     .Select(int.Parse)
                     .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            Console.WriteLine();
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}