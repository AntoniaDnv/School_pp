namespace Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string list = Console.ReadLine();

            if (list.Length % 2 != 0)
            {
                Console.WriteLine($"NO");
                return;
            }


            for (int i =0; i < list.Length/2; i++)
            {
               
                if (((list[i] == '{' && list[list.Length - 1 -i] != '}') && (list[i] == '[' && list[list.Length - 1 - i] != ']' ) && (list[i] == '(' && list[list.Length - 1 - i] != ')')))
                {
                    Console.WriteLine($"NO");
                    return;
                }
                
                
            }

            Console.WriteLine("YES");


        }
    }
}