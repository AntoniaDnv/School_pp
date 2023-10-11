namespace MiniTestArry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arryOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        
               ;

            string[] arryTwo = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)

          ;
           

            for(int i = 0; i < arryTwo.Length; i++)
            {
                for(int j = 0; j < arryOne.Length; j++)
                {
                    if (arryOne[j] == arryTwo[i])
                    {
                        Console.Write($"{arryTwo[i]} ");
                    }

                }
              
            }

            Console.WriteLine();

        }
    }
}