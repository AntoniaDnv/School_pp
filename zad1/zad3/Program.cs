using System.Numerics;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int lives = 2;
            int row = 0;
            int col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char element = char.Parse(Console.ReadLine());
                    if(element == 'P')
                    {
                        row = i;
                        col = j;
                    }
                    matrix[i, j] = element;
                    
                }
            }


            while (true)
            {
                string command = Console.ReadLine();
                switch(command)
                {
                    case "right":
                        col = col + 1;
                        MoveRight(matrix, col, row, lives);
                        break;
                    case "left":
                        col = col - 1;
                        MoveLeft(matrix, col, row, lives);
                        break;
                    case "down":
                        row = row - 1;
                        MoveDown(matrix, col, row, lives);
                        break;
                    case "up":
                        row = row + 1;
                        MoveUp(matrix, col, row, lives);
                        break;

                }
                CheckIfwon(matrix);
            }

        }
       
        
        static void MoveRight(char[,]matrix, int col , int row, int lives)
        {
            if (matrix[col, row] == 'G')
            {
                lives--;
            }



            matrix[row, col + 1] = '-';
            matrix[row, col] = 'P';
        }

        static void MoveLeft(char[,] matrix, int col, int row, int lives)
        {
            if (matrix[col, row] == 'G')
            {
                lives--;
            }

            matrix[row, col - 1] = '-';
            matrix[row, col] = 'P';
        }
        static void MoveDown(char[,] matrix, int col, int row, int lives)
        {
            if (matrix[col, row] == 'G')
            {
                lives--;
            }
            matrix[row - 1, col] = '-';
            matrix[row, col] = 'P';
        }
        static void MoveUp(char[,] matrix, int col, int row, int lives)
        {
            if (matrix[col, row] == 'G')
            {
                lives--;
            }
            matrix[row + 1, col] = '-';
            matrix[row, col] = 'P';
        }



        static bool CheckIfwon(char[,] matrix)
        {
            bool check = false;
            for(int i = 0; i < matrix.GetLength(0); i++) 
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    if ( matrix[i, j] != 'E')
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
    }
}