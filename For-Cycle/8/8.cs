namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MaxValue;
            int min = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= max)
                {
                    max = number;
                }
                if (number >= min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"Max number: {min}");
            Console.WriteLine($"Min number: {max}");
        }
    }
}