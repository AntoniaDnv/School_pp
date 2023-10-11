namespace ArryRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arry = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());  
            

            for(int i = 0;i < n; i++)
            {
                for(int j = arry.Length-1; j >= 0; j--)
                {
                    int temp = arry[arry.Length - 1]; // 30
                    arry[arry.Length - 1] = arry[j]; //30 = 20

                    arry[j] = temp;// 20 = 30

                }
            }
          Console.WriteLine(string.Join(" ", arry));
        }
    }
}