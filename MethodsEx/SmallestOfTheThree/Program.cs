namespace SmallestOfTheThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            GetMax(n1, n2, n3 );
        }
        static void GetMax(int n1, int n2, int n3)
        {
            if(n1 < n2)
            {
                if(n1 < n3)
                {
                    Console.WriteLine(n1);
                }
            }
             if(n1 > n2)
            {
                if(n2< n3)
                {
                    Console.WriteLine(n2);
                }
            }
             if (n2 > n3)
            {
                if (n3 < n1)
                {
                    Console.WriteLine(n3);
                }
            }
        }

    }
}