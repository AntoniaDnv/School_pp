namespace zad1._01
{
    internal class zad2
    {
        static void Main(string[] args)
        {
                double n = double.Parse(Console.ReadLine());
                double m = double.Parse(Console.ReadLine());
                double sum = 0;

                for (int i = 0; i < m; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());

                sum = num1 + num2; 

                if (sum > n)
                {
                    Console.WriteLine($"Bigger Sum!");
                }
            }
        }
    }
}