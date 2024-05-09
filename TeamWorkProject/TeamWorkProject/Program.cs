using System.IO.Pipes;

namespace TeamWorkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
          
          var teams = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i = 0)
            {
                string[] input = Console.ReadLine().Split("-");
                string user = input[0];
                string teamName = input[1];
                if (teamName.Contains(">") && teams.ContainsKey(teamName))
                {
                    teamName.Split(">");
                    if (!teams.ContainsValue(teams[user]))
                    {
                        teams[teamName].Add(user);
                    }
                }
                else
                {
                    i++;
                    teams.Add(teamName, );
                }
            }

        }
    }

    public class Projects
    {
        public string User { get; set; }
        public string TeamName { get; set; }

        public Projects(string user, string teamName) 
        { 
            User = user;
            TeamName = teamName;
        }


    }
}