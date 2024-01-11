namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
              
            int[,] matrix = new int[size, size];
           
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
            int sum = 0;
            sum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            Console.WriteLine(sum);
        }
    }
}