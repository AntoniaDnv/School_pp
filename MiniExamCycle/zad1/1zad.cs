namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double num = double.Parse(Console.ReadLine());

                if (num %10 == 0) 
                {
                    Console.WriteLine($"The number is:{num}");
                    break;

                }
                else if (!(num %10 == 0))
                {
                    Console.WriteLine($"Invalid number!");
                                 
                    
                }
            }
        }
    }
}