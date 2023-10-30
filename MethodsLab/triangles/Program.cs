using System.Security.Cryptography.X509Certificates;

namespace triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            int start = 1;
            int end = n ;

            PrintLine( start,  end);
            Print( n,  start);


        }
        static void PrintLine(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void Print (int n, int start)
        {
            for(int line = 0; line < n; line++) 
            { 
                Console.Write("1", line);
            }
            for(int line = n-1; line >=1; line--)
            {
                Console.Write("1", line);
            }
        }
    }
}