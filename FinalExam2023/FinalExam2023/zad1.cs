namespace FinalExam2023
{
    internal class zad1
    {
        static void Main(string[] args)
        {
           double pricefGolf = double.Parse(Console.ReadLine());
           double n = double.Parse(Console.ReadLine());
           double m = double.Parse(Console.ReadLine());
           double priceBall = pricefGolf  / 6;
           double clothes =( pricefGolf * n + priceBall * m)*0.2;

            double finalPrice = clothes + pricefGolf * n + priceBall * m;

            Console.WriteLine($"Tony should pay {(Math.Floor(finalPrice/8))}");
            Console.WriteLine($"Sponsors should pay {0.875*(Math.Ceiling(finalPrice)):f0}");

        }
    }
}