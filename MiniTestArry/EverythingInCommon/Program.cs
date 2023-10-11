namespace EverythingInCommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arry2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool equal = false;
            int count = 0;

           for( int i = 0; i < arry1.Length; i++)
            {
                if(arry1[i] != arry2[i])
                {
                    Console.WriteLine($"Arrays are not identical.");
                    Console.WriteLine($"Found difference at {i} index");
                    equal = false ;

                    break;
                   
                }
                sum+= arry1[i]; 
                if(arry1.Length-1 == arry2.Length-1 && i == arry1.Length-1)
                {

                    equal = true;
                    if (true)
                    {
                        Console.WriteLine($"Arrays are identical.");
                        Console.WriteLine($"Sum {sum}");

                    }
                }
               
            }
            


        }
    }
}