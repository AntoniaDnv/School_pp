namespace FootbalTeamGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                    string[] parts = input.Split(';');
                string command = parts[0];
                string teamName = parts[1];

                try
                {
                    switch (command)
                    {
                        case "Team":
                            teams[teamName] = new Team(teamName);
                            break;

                        case "Add":
                            if (!teams.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                break;
                            }

                            string playerName = parts[2];
                            int endurance = int.Parse(parts[3]);
                            int sprint = int.Parse(parts[4]);
                            int dribble = int.Parse(parts[5]);
                            int passing = int.Parse(parts[6]);
                            int shooting = int.Parse(parts[7]);

                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            teams[teamName].AddPlayer(player);
                            break;

                        case "Remove":
                            if (!teams.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                break;
                            }

                            string playerToRemove = parts[2];
                            teams[teamName].RemovePlayer(playerToRemove);
                        break;

                        case "Rating":
                            if (!teams.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team {teamName}  does not exist.");
                                break;
                            }

                            Console.WriteLine(teamName + " - " + teams[teamName].Rating);
                            break;

                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
