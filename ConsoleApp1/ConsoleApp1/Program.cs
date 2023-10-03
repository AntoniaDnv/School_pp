using System.Transactions;
using System.Windows.Markup;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double output = input / 1000;
            Console.WriteLine($"{output:f2}");
        }
    }
}