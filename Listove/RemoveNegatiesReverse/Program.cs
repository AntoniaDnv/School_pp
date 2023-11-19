namespace RemoveNegatiesReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            nums.RemoveAll(nums => nums < 0);

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int temp = nums[0];
                    nums.RemoveAt(0);
                    nums.Add(temp);
                }

            }
                Console.WriteLine(string.Join(" ", nums));
           }
        }
    }
