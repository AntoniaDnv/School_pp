namespace HDHDHD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kgLime = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double alllime = kgLime * 980;
            double lemonade = alllime + water * 1000 + (0.30 * sugar);
            double soldcups = Math.Floor(lemonade / 150);
            double pari = soldcups * 1.2;
            Console.WriteLine(soldcups);
            Console.WriteLine(pari);
        }
    }
}