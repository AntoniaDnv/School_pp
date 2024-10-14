namespace Godzila
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());
            double clothesMoney=0;
            double director = budget * 0.10;
            
            if (statists > 150) 
            {

                 clothesMoney = (statists * priceClothes)-0.10* (statists * priceClothes);
            }
            else if (statists <= 150)
            {
                clothesMoney = statists * priceClothes;
            }

            double priceOfFilm = clothesMoney + director;
            if (priceOfFilm <= budget)
            {
                double leftMoney = budget- priceOfFilm;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
            else if (priceOfFilm> budget)
            {
                double neededMoney = priceOfFilm- budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
        }
    }
}