using System.Diagnostics;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = GetCommand();

           while(command[0]?.ToLower() != "end")
           {
             

                switch (command[0])
                {
                    case "Delete":
                        nums.RemoveAll(a=> a== int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
                command = GetCommand();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static string[] GetCommand()
        {
            return Console.ReadLine()
               .Split(" ")
               .ToArray();
               
        }
    }
}