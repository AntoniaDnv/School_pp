namespace StackExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToArray();
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(nums);
            
            bool check = false;
           
            int minN = int.MaxValue;

            for (int j = 0; j < commands[1]; j++)
            {
                stack.Pop();
            }
           
            if (stack.Count <= 0)
            {
                Console.WriteLine("nothing found");
                return;
            }
            for (int k = 0; k < stack.Count; k = 0)
            {
                int top = stack.Peek();
                if (top < minN)
                {
                    minN = top;
                }

                if (top == commands[2])
                {
                    Console.WriteLine("found");
                    return;
                }
                else
                {
                    stack.Pop();

                }
            }
            Console.WriteLine(minN);

            
        }
    }
}