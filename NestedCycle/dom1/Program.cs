using System;
namespace dom1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
           double current = 1;
           bool IsBigger = false;
            

            for(int rows = 1; rows <= number; rows++)
            {
                
                for(int colums = 1; colums <= rows; colums++)
                {
                    if (current> number)
                    {
                     IsBigger = true;
                     break;
                    }
                   Console.Write(current + " ");
                    current++;
                }
                if(IsBigger)
                {
                    break;
                }
                Console.WriteLine();    
            }
        }
    }
}