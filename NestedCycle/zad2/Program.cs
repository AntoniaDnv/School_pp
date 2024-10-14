using System;
namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10+1; i++)
            {
                for(int j = 1; j < 10+1; j++)
                {
                    
                    int m = i*j;
                    Console.WriteLine($"{i} * {j} = {m}");
                }
            }
        }
    }
}