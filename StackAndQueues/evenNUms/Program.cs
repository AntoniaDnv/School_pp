namespace evenNUms
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
           

            Stack<int> nums = new Stack<int>(input);

            Stack<int> result = new Stack<int>();

            Stack<int> reverse = new Stack<int>();

            int counter = 0;

            while(nums.Count > 0)
            {
                reverse.Push(nums.Pop());
            }

            foreach (int i in reverse)
            {
                counter++;

                if (i % 2 == 0)
                {
                    result.Push(i);
                    if(reverse.Count>counter)
                    {
                        Console.Write($"{result.Pop()}, ");
                    }
                    else
                    {
                        Console.Write($"{result.Pop()}");
                    }
                   
                }
               
            }

           
        }
    }
}