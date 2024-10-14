using System.Diagnostics.Metrics;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
         {
           double start = double.Parse(Console.ReadLine());
           double end = double.Parse(Console.ReadLine());
           double n = double.Parse(Console.ReadLine());
            double counter = 0;

           for (double i = start; i <= end; i++)
            {
            
                for(double j = start; j <= end ; j++)
                {
                  
                    counter++;
                    if(start + j == n)
                    {
                        Console.WriteLine($"Combination N:{counter} ({start} + {j} = {n})");
                        return;
                    }
                   
                }              
            }
           if (!(start + end == n))
            {
                Console.WriteLine($"{counter} combinations- neither equals {n}");
            }
        }
    }
}