namespace listOfPredicadess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int, int, bool> func = (a, b) => a % b ==0;
            List<int> divisibleNum = new List<int>();
            bool divisible = true;
           for(int j = 1; j <= n; j++) 
           {
                divisible = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!func(j, nums[i]))
                    {
                        divisible = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (divisible == true)
                {
                    divisibleNum.Add(j);    
                }
           }
            Console.WriteLine(string.Join(" ", divisibleNum));
        }
    }
}