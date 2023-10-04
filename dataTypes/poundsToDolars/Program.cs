namespace poundsToDolars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal outbup = input * 1.31m;
            Console.WriteLine($"{outbup:f3}");
        }
    }
}