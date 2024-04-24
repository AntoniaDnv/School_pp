namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            
            int heigth = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

             Rectangle firstRect = new Rectangle(width, heigth, color);
            Console.WriteLine($"Rect({firstRect.Width}, {firstRect.Height}, {firstRect.Color}) has area {firstRect.CalcArea()}.");
        }
    }
}