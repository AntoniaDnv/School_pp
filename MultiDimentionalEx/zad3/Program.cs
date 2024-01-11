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
            int[,] matrix = new int[size[0], size[1]];





        }
    }
}