﻿namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input =

             Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {

                var tokens = commandInfo.Split();

                var command = tokens[0].ToLower();

                if (command == "add")

                {
                    var addablesd = int.Parse(tokens[1]);
                    var addableTwo = int.Parse(tokens[2]);

                    stack.Push(addablesd);
                    stack.Push(addableTwo);


                }

                else if (command == "remove")
                {
                    var countOfRemovedNums = int.Parse(tokens[1]);

                    if (stack.Count > countOfRemovedNums)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)

                        { stack.Pop(); }
                    }


                   

                }
                commandInfo = Console.ReadLine().ToLower();

            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        } 
       
    }
    
}
    