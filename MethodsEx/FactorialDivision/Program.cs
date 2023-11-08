namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
          int m = int.Parse(Console.ReadLine());

            Calculations(n, m);
        }
        static void Calculations(int n, int m)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i; 
            }

            int resultForM = 1;
            for (int i = m; i > 0; i--)
            {
                resultForM *= i;
            }

            Console.Write($"{(result/resultForM):f2}");

        }
    }
}