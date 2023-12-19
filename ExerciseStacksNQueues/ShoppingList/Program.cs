using System.Diagnostics.Contracts;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shop = Console.ReadLine()
                .Split("!");
            List<string> list = new List<string>(shop);
            string[] command = Console.ReadLine()
                .Split();

            while(command[0] != "Go" && command[1] != "Shopping!")
            {
                switch(command[0]) {
                    case "Urgent":
                      
                        if (list.Contains(command[1]))
                        {
                            break;
                        }
                      
                        list.Insert(0, command[1]);
                      
                        break;
                 
                    case "Unnecessary":
                     
                        list.Remove(command[1]);
                        break;
                  
                    case "Correct":
                       
                        if (list.Contains(command[1]))
                        {
                            list.Remove(command[1]);
                            list.Add(command[2]);
                        }
                        break;
                  
                    case "Rearrange":
                     
                        if (list.Contains(command[1]))
                        {
                            list.Remove(command[1]);
                            list.Add(command[1]);
                        }
                        break;
                }
                command = Console.ReadLine()
                    .Split();
            }
            for(int i =0; i < list.Count; i++)
            {
                if(i+1 == list.Count)
                {
                    Console.Write(list[i]);
                    return;
                }
              
                Console.Write(list[i]+ ","+ " ");
            }
        }
    }
}