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
            int max = int.MinValue;

            for (int i = 0; i < arry.Length; i++)
            {
                
                if (arry[i] > max)
                {
                    max = arry[i];
                }
            }
            for(int i = 0;i < max.Length;i++)
            {

            }

        }
    }
}