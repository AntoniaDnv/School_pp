namespace SNQ_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input =

         Console.ReadLine()
         .Split()
         .Select(int.Parse)
         .ToArray();

            Stack<int> stack = new Stack<int>(input);
            Stack<int> reversed = new Stack<int>();    

            int capacity = int.Parse(Console.ReadLine());

            int recks = 1;

            int currentSum = 0;

            while (stack.Count > 0)
            {
              reversed.Push(stack.Pop());
            }

            while (reversed.Count > 0)
            {
                if (currentSum + reversed.Peek() <= capacity)
                {
                    currentSum += reversed.Pop();
                }
                else
                {
                    currentSum = reversed.Pop();
                    recks++;
                }
            }

            Console.WriteLine(recks);
        }
    }
}