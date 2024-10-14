using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double evenNumSum = 0;
            double oddNumSum = 0;

            double max = int.MinValue;
            double min = int.MaxValue;
            double max2 = int.MinValue;
            double min2 = int.MaxValue;



            for (int i = 1; i < numbers+1; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                if( i % 2 == 0 )
                {
                    evenNumSum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }

                }
                else if ( i % 2 != 0 )
                {
                    oddNumSum += num;
                    if (num > max)
                    {
                        max2 = num;
                    }
                    if (num < min)
                    {
                        min2 = num;
                    }
                }
                
            }
            
            Console.WriteLine($"OddSum={ oddNumSum:f2}");
           
            if (oddNumSum == 0)
            {
                Console.WriteLine("No");
            }
            else {
                Console.WriteLine($"OddMin={min2:f2}");
            }
            if (oddNumSum == 0)
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine($"OddMax={max2:f2}");
            }
           
            Console.WriteLine($"EvenSum={evenNumSum}");
            
            if (evenNumSum == 0)
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine($"EvenMin={min:f2}");
            }
            if ( evenNumSum == 0 )
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine($"EvenMax={max:f2}");
            }
           

        }
    }
}