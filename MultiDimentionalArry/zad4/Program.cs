namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
             
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"{row}, {col}");
                        counter++;
                    }
                }
            }
            if( counter <= 0 )
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}