namespace FunctionProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n %2 == 0)
                .OrderBy(n  => n)
                .ToArray();
            string result = string.Join(", ", nums);

            Console.WriteLine(result);
        }
    }
}