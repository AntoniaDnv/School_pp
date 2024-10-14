namespace GoldenButterfly
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double rent = double.Parse(Console.ReadLine());
          double statue = rent - rent * 0.35;
          double katering = statue - statue * 0.25;
          double musick = katering * 2 / 3;
          double total = rent + statue + katering + musick;
            Console.WriteLine($" The total cost of the ceremony is {total:f2}.");
        }
    }
}