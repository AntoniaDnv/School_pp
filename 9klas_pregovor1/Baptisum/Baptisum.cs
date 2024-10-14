namespace Baptisum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.25;
            double drinks = cake - cake * .4;
            double keturing = rent / 2;
            double total = rent +cake +drinks + keturing;
            Console.WriteLine($"{total:f2}");
        }
    }
}