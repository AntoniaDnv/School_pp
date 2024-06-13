namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split("<->");
            while(command[0] != "Read")
            {
                switch (command[0]) 
                {
                    case "Space":
                        input = input.Insert(int.Parse(command[1]), " ");
                        Console.WriteLine(input);
                      
                        break;

                    case "Backward":
                        string wordBack = "";
                        int index = input.IndexOf(command[1]);
                        
                        if (input.Contains(command[1]))
                        {
                           for(int i = 0; i<= command[1].Length-1; i++)
                           {
                                wordBack = wordBack + command[1][command[1].Length-i-1];
                               
                           
                           }
                            input = input.Remove(index, command[1].Length);
                            input = input.Insert(index, wordBack);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        if (input.Contains(command[1]))
                        {
                            break;
                        }
                        break;
                    case "ReplaceAll":
                        input = input.Replace(command[1], command[2]);
                        Console.WriteLine(input);
                        break;

                }
              
                command = Console.ReadLine().Split("<->");
            }

            Console.WriteLine($"You have a secret text message: {input}");
        }
    }
}