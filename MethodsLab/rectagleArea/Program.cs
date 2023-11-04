namespace rectagleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
            double area = RectangleArea(a, b);
            double RectangleArea(double a, double b)
            {
                return a * b;
            }
        }

    
    }
}