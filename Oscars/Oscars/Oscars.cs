namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int rent = int.Parse(Console.ReadLine());
            double statues = rent - rent * 0.3;
            double food = statues - statues * 0.15;
            double sound = food * 1 / 2;
            double spent = rent+ statues+ food+sound;
            Console.WriteLine($"{spent:f2}");
        }
    }
}