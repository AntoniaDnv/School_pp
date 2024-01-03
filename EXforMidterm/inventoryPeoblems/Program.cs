using System.Runtime.CompilerServices;

namespace inventoryPeoblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] m = Console.ReadLine()
                .Split(", ");
              
            List<string> materials = new List<string>(m);

            string[] command = Console.ReadLine()
                .Split();
                
            while (command[0] != "Craft!")
            {
                switch(command[0])
                {
                    case "Collect":
                        if (materials.Contains(command[0]))
                        {
                            break;
                        }
                        else
                        {
                            materials.Add(command[2]);
                        }
                        break;

                    case "Drop":
                        if (materials.Contains(command[2]))
                        { 
                           

                            materials.Remove(command[2]);
                        }
                        break;

                    case "Combine":
                      string[] tokens =   command[3].Split(":");
                        if (materials.Contains(tokens[0]))
                        {
                            int index = 0;
                            for (int i = 0; i < materials.Count; i++)
                            {
                                if (materials[i] == tokens[0])
                                {
                                    index = i +1 ;
                                    i = 100;
                                }

                            }
                            materials.Insert(index, tokens[1]);
                        }

                        break;
                    case "Renew":
                        if (materials.Contains(command[2]))
                        {
                            string item = command[2];
                            materials.Remove(item);
                            materials.Add(item);
                        }
                        break;
                }

                command = Console.ReadLine()
                    .Split() ;
            }
            Console.WriteLine($"{String.Join(" ", materials)}");
        }
    }
}