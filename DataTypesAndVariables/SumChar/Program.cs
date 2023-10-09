using System.Text;

namespace SumChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nums= int.Parse(Console.ReadLine());
           int sum = 0;
            
            for(int i = 0; i < nums; i++)
            {
                char s = char.Parse(Console.ReadLine());

                //Console.WriteLine("The code of '{0}' is: {1}", s, (int)s);
                sum += (int)s;

            }
            Console.WriteLine($"The sum equals:{sum}");
        }
    }
}