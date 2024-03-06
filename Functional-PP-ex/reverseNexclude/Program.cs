namespace reverseNexclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            nums= nums.Where(x => x % n != 0)
                             .Reverse()
                             .ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}