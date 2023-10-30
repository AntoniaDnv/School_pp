namespace signOfIntigerNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Desision(n);
        }

        static void Desision(int n)
        {
            if(n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if(n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }
    }
}