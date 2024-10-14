using System;
namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); 
            double counter =0;

            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    for(int k= 0; k <= n; k++)
                    {
                        if(i + j + k ==n)
                        {
                            counter++;
                        }
                        
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}