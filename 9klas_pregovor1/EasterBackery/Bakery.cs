namespace EasterBackery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double priceSugar = priceFlour - priceFlour*0.2;
            double kgSugar = double.Parse(Console.ReadLine());
            double priceEggs = priceFlour + priceFlour*0.15;
            double eggNum = double.Parse(Console.ReadLine());
            double maia = priceSugar * 0.25;
            double maiaNum = double.Parse(Console.ReadLine());

            double money1 = Math.Round(priceEggs * eggNum,2);
            double money2 = Math.Round(priceSugar * kgSugar,2);
            double money3 = Math.Round(priceFlour * kgFlour, 2);
            double money4 = Math.Round(maia * maiaNum, 2);
            double allMoney = money1 + money2 + money3 + money4;

            Console.WriteLine($"{allMoney:f2}");
        }
    }
}