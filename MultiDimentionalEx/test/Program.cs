namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];
        }
    }
}