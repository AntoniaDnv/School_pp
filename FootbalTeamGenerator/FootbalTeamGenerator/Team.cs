using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (players.Count == 0) 
                {
                    return 0;
                }

                double totalSkill = 0;

                foreach (Player player in players)
                {
                    totalSkill += player.SkillLevel;
                }

                double averageSkill = totalSkill / players.Count; 
                return (int)Math.Round(averageSkill);
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = players.FirstOrDefault(p => p.Name == playerName);
            if (player == null)
            {
                Console.WriteLine($"Player {playerName} is not in {Name} team.");
            }
            else
            {
                players.Remove(player);
            }
        }
    }
}
