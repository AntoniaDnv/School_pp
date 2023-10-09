namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
          decimal a = decimal.Parse(Console.ReadLine());
          decimal b = decimal.Parse(Console.ReadLine());
          decimal c = decimal.Parse(Console.ReadLine());
          decimal d = decimal.Parse(Console.ReadLine());

            decimal e = a + b;
            decimal f = e / c;
            decimal g = f * d;
            Console.WriteLine(g);
        }
    }
}