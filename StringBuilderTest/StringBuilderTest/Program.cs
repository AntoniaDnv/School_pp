using System.Globalization;

namespace StringBuilderTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = 0;
            string[] input = Console.ReadLine()
                .Split();
           int output = 0;
            if (input[0].Length> input[1].Length)
            {
                min = input[1].Length;
                max = input[0].Length;  
            }
            else
            {
                min = input[0].Length;
                max = input[1].Length;
            }

                if (input[0].Length == input[1].Length)
                {
                int a = 0;
                for (int i = 0; i < min; i++)
                    {
                   

                        for (int j = a; j < max; a++)
                        {
                            
                            char c = input[1][j];
                            output += (int)(c)* (int)(input[0][i]);
                            break;

                        }

                    a++;
                       
                    }
                }
            else
            {
                int m = 0;
                for (int i = 0; i < min; i++)
                {
                    
                    for (int j = 0; j < max; j++)
                    {
                        if (m>0) 
                        {
                            break;
                        }
                        
                        char c = input[1][j];
                        output += (int)(c);

                    }
                
                    m++;
                    output += (int)(input[0][i]);
                }
            }//
            Console.WriteLine(output);
        }
    }
}