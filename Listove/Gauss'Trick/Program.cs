namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                .ToList();
            Console.WriteLine(Trick(numbers));
           
        }
        static string Trick(List<int> numbers)
        {
            int lenght = numbers.Count;

            for (int i = 0; i < lenght / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
        string result =   string.Join(" ", numbers);
            return result;
        }
    }
}