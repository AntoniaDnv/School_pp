using System.Text;

namespace MultiplyBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine());
             int smallNum = int.Parse(Console.ReadLine());  
             StringBuilder some = new StringBuilder();

            for(int i = 0; i < smallNum-1; i++)
            {
                num += num;
                
            }
            some.Append(num);
            Console.WriteLine(some.ToString());
        }
    }
}