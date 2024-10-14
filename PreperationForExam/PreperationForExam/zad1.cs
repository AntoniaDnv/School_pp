namespace PreperationForExam
{
    internal class zad1
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double shoes = tax - tax * 0.4;
            double clothes = shoes - shoes * 0.20;
            double ball = 0.25* clothes;
            double acesories = 0.2 * ball;
            double all = tax + shoes + clothes + ball + acesories;
            Console.WriteLine($"{ all:F2}");

        }
    }
}