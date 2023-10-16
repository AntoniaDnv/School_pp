namespace TopIntigers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
          

            for (int i = 0; i < arry.Length; i++)
            {
                bool f = true;
                for (int j = i+1; j<arry.Length; j++)
                {
                    if (arry[j] >= arry[i])
                    {
                        f = false;
                        break;
                     

                    }
                  
                }
                if (f == true)
                {
                    Console.Write($"{arry[i]} "); 
                }
            }
            

        }
    }
}