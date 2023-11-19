using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ListOpperations
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

            while (command[0]?.ToLower() != "end")
            {


                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (int.Parse(command[2]) <= nums.Count)
                        {
                            if (command[1] == "left")
                            {
                                for (int i = 0; i < int.Parse(command[2]); i++)

                                {
                                    int temp = nums[0];
                                    nums.RemoveAt(0);
                                    nums.Add(temp);

                                }
                            }
                            else
                            {
                                for (int i = 0; i <= int.Parse(command[2]); i++)

                                {
                                    int temp = nums[0];
                                    nums.Add(temp);
                                    nums.RemoveAt(0);


                                }

                            }
                        }
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