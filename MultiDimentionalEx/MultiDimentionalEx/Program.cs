using System.Dynamic;

namespace MultiDimentionalEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) -1; row++) 
            {
                for (int col = 0; col < matrix.GetLength(1) -1; col++)
                {
                    if(matrix[row, col] == matrix[row + 1, col] && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        if (matrix[row, col] == matrix[row, col + 1])
                        {
                            count++;
                        }
                    }
                   
                }
            }
            Console.WriteLine(count);
            
        }
      
    }
}