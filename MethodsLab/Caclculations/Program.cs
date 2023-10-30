using System.ComponentModel;

namespace Caclculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string expresion = Console.ReadLine();
          int n  = int.Parse(Console.ReadLine() );
            int m = int.Parse(Console.ReadLine());

            switch( expresion )
            {
                case "add":
                    add(n, m);
                    break;

                case "multiply":
                    multiply(n, m);
                    break;
                case "subtract":
                    subtract(n, m);
                    break;

                case "divide":
                    divide(n, m);
                    break;
            }
        }
          static void add (int n, int m)
        {
            Console.WriteLine(n + m);
        }

        static void multiply(int n, int m)
        {
            Console.WriteLine(n * m);
        }

        static void subtract(int n, int m)
        {
            Console.WriteLine(n - m);
        }

        static void divide(int n, int m)
        {
            Console.WriteLine(n / m);
        }
    }
}