using System.Data;
using System.Diagnostics;
using System.Transactions;

namespace ListsExcersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetIntList();

            int capacity = int.Parse(Console.ReadLine());

            string[] command = GetStringArry();

            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower()) 
                {
                    case "add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                      
                        AddNumToListElement(train, capacity, int.Parse(command[0]));
                        break;
                }



                command = GetStringArry();
            }
            Console.WriteLine(string.Join(" ", train));
        }
        static List<int> GetIntList()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        static string[] GetStringArry()
        {
            return  Console.ReadLine()
                .Split(" ")
                .ToArray()
                ;
        }
        static List<int> AddNumToListElement(List<int> train,int capacity, int command)
        {
            //int convertedNumber = int.Parse(command[0]);

            for (int i = 0; i < train.Count; i++)
            {
                if (train[i] + command <= capacity)
                {
                    train[i] += command;
                    break;
                }
            }
            return train;
        }

    }
}