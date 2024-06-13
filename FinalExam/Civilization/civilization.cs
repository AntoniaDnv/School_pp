namespace Civilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("---");
            Dictionary<string,List<int>> dictionary = new Dictionary<string,List<int>>();
            while(command[0]!= "Build")
            {
                string town = command[0];
                int facilities = int.Parse(command[1]);
                int score = int.Parse(command[2]);

                if(dictionary.ContainsKey(town) )
                {
                    dictionary[town][0] += facilities;
                    dictionary[town][1] += score;
                }
                else
                {
                    dictionary.Add(town, new List<int>());
                    dictionary[town].Add(facilities);
                    dictionary[town].Add(score);
                }
                command = Console.ReadLine().Split("---");
            }
            command = Console.ReadLine().Split(">>");
            while (command[0] != "End")
            {
                string city = command[1];
                int facilities = int.Parse(command[2]);
                

                switch (command[0])
                {
                    case "Sabotage":
                        int score = int.Parse(command[3]);
                        Console.WriteLine($"Campus in {city} is sabotaged! You now have {facilities} less functioning facilities and decreased with {score} science score.");
                        dictionary[city][0] = dictionary[city][0] - facilities;
                        dictionary[city][1] = dictionary[city][1] - score;
                        if (dictionary[city][0] <= 0 || dictionary[city][1] <= 0)
                        {
                            Console.WriteLine($"The campus in {city} has been destroyed!");
                            dictionary.Remove(city);
                        }
                        break;
                    case "Boost":
                        if (facilities < 0)
                        {
                            Console.WriteLine("Score cannot be boosted with a negative amount!");
                            break;
                        }
                       
                        dictionary[city][1] = dictionary[city][1] + facilities;
                        Console.WriteLine($"{facilities} science boost added to the Campus in {city}. The Campus now has total science score: {dictionary[city][1]}.");
                        break;
                }
                command = Console.ReadLine().Split(">>");
            }
            if (dictionary.Count <= 0)
            {
                Console.WriteLine($"Pity! All Campuses have been sabotaged and destroyed!");
                return;
            }
            Console.WriteLine($"You have {dictionary.Count} Campuses discovering science:");
            foreach( var city in dictionary.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{city.Key} -> Facilities: {city.Value[0]}, Science score: {city.Value[1]}");
            }
        }
    }
}