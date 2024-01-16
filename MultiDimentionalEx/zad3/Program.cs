namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            
            char[,] matrix = new char[size[0], size[1]];
            
            string snake = Console.ReadLine();
           
            int snakeIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                bool isEven = row % 2 == 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (isEven)
                    {
                        matrix[row, col] = snake[snakeIndex];
                    }
                    else
                    {
                        matrix[row, matrix.GetLength(1) - 1 - col] = snake[snakeIndex];
                    }

                    snakeIndex = (snakeIndex + 1) % snake.Length;
                }
            }


            for (int rowe = 0; rowe < matrix.GetLength(0); rowe++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[rowe, col]);
                }
                Console.WriteLine();
            }
            




        }
    }
}