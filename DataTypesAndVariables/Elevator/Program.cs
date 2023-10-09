namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numP = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());


            int course = (int)Math.Round((double)numP / capacity);
           if (numP==0 && capacity == 0)
            {
                Console.WriteLine(0);
            }
           else if(numP/capacity < 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Math.Abs(course));
            }
            
        }
    }
}