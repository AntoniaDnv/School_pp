namespace Supermarcket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                ;
            int counter = 0 ;
            Stack<string> stack = new Stack<string>();
            Stack<string> output = new Stack<string>();
            while (input != "End")
            {

                if (input == "Paid")
                {
                    counter = 0;
                    stack.Reverse();
                    foreach (var item in stack)
                    {
                       output.Push(item);
                        
                    }
                    while(output.Count > 0)
                    {
                        Console.WriteLine(output.Pop());
                    }
                  
                    for (int i = 0; i < stack.Count; i++)
                    {
                        stack.Pop();
                     
                    }

                    
                }
                else
                {
                    counter++;
                    stack.Push(input);
                }
                input = Console.ReadLine() ;
             
            }
            Console.WriteLine($"{counter} people remaining.");
            
        }
    }
}