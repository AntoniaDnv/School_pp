using System.Reflection.Metadata.Ecma335;

namespace filterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for(int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                people.Add(names[0], 0);
                people[names[0]] = int.Parse(names[1]);

            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] printFormat = Console.ReadLine()
                .Split();
            if(condition == "older")
            {
                if (printFormat[0] == "name" && printFormat.Length == 0)
                {
                    foreach(var kvp in people)
                    {
                        if(kvp.Value > age)
                        {
                            Console.WriteLine(kvp.Key);
                        }
                    }
                }
                else if (printFormat[0] == "age")
                {
                    foreach (var kvp in people)
                    {
                        if (kvp.Value >= age)
                        {
                            Console.Write(kvp.Key);
                            Console.Write($" - {kvp.Value}");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    foreach (var kvp in people)
                    {
                        if (kvp.Value >= age)
                        {
                            Console.Write(kvp.Key);
                            Console.Write($" - {kvp.Value}");
                            Console.WriteLine();
                        }
                    }
                }
            }
            else 
            {
                if (printFormat[0] == "name")
                {
                    foreach (var kvp in people)
                    {
                        if (kvp.Value <= age)
                        {
                            Console.WriteLine(kvp.Key);
                        }
                    }
                }
                else if (printFormat[0] == "age")
                {
                    foreach (var kvp in people)
                    {
                        if (kvp.Value < age)
                        {
                            Console.WriteLine($" {kvp.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var kvp in people)
                    {
                        if (kvp.Value < age)
                        {
                            Console.Write(kvp.Key);
                            Console.Write($" {kvp.Value}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}