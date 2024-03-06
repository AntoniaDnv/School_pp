namespace add_Vat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func < double, double> checker = n => n + n%20;

            double[] prices = Console.ReadLine()
             .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
             .Select(double.Parse)
             .Select(n => n * 1.2)
             .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}