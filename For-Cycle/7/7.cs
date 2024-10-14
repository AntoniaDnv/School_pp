namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double end = 0; 
            for(int i = 1; i <= n; i++)
            {
            double m = double.Parse(Console.ReadLine());
                 sum +=m;
                
            }
            Console.WriteLine(sum);
        }
    }
}