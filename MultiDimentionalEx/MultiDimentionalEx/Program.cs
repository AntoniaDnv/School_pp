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
            int[,] maxMatrix = new int[3, 3];
           
            int sum = 0;
            int max = int.MinValue;
      
            int m = 0;
            int d = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) -2; row++) 
            {
                for (int col = 0; col < matrix.GetLength(1) -2; col++)
                {

                  sum = matrix[row, col] + matrix[row, col+1] + matrix[row, col+2] +
                        matrix[row + 1, col] + matrix[row+1,  col+1] + matrix[row+1, col + 2]+
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row+2, col + 2];
                   if(sum > max)
                   {
                        max = sum;
                        m = col;
                        d = row;
                   }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"{matrix[d, m]} {matrix[d, m+1]} {matrix[d, m+2]}" +
                $"\n{matrix[d + 1, m]} {matrix[d+1,  m+1]} {matrix[d+1, m + 2]}" +
                $"\n{matrix[d + 2, m] } {matrix[d + 2, m + 1]} {matrix[d+2, m + 2]}");
           
            
        }
      
    }
}