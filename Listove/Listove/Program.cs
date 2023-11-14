

namespace Listove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                .ToList();

            int lenght = numbers.Count;

            for(int i = 0; i < lenght; i++)
            {

            }
        }
    }
}