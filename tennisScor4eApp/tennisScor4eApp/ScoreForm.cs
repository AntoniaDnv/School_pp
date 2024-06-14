using System.Numerics;
using System.Reflection;

namespace tennisScor4eApp
{
    public partial class ScoreForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new()
        {
            {"R. Federer", 4 },
             {"G. Dimitrov", 5},
              {"R. Nadal", 4 },
        };

        private static Dictionary<(string, int), List<(string, int)>> games = new Dictionary<(string, int), List<(string, int)>>()
        {
            { ("G. Dimitrov", 3), new List<(string, int)>() { ("R. Nadal", 2) } },
            { ("R. Nadal", 3), new List<(string, int)>() { ("R. Federer", 1) } },
            { ("G. Dimitrov", 2), new List<(string, int)>() { ("R. Federer", 3) } },
        };


        public ScoreForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {

            FillRankingLsitView();
            FillLatestGamesView();
        }
        private void FillRankingLsitView()
        {
            this.LVRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();
                ListViewItem rollInRanckingListView = new();
                rollInRanckingListView.SubItems[0].Text = playerName;
                rollInRanckingListView.SubItems.Add(playerPoints);
                this.LVRanking.Items.Add(rollInRanckingListView);
            }
        }

        private void FillLatestGamesView()
        {
            this.LVLatestGames.Items.Clear();
            
            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
             string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new ListViewItem();
            rollInLatestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGamesListView.SubItems.Add(secondPlayer.Item1);
             rollInLatestGamesListView.SubItems.Add(winner);
            rollInLatestGamesListView.SubItems.Add($"{firstPlayer.Item2} : {secondPlayer.Item2}");

            this.LVLatestGames.Items.Add(rollInLatestGamesListView);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }

            return "Draw";
        }

        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using (newGame newGameForm = new newGame())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }


        }
        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
             FillPlayerWithPoints(firstPlayer);
             FillPlayerWithPoints(secondPlayer);

            FillRankingLsitView();
            FillLatestGamesView();

        }
        private void FillGamesData((string, int) firstPlayer,(string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)>() { secondPlayer });
            }
        }
        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }
        private void listViewRankings_Click(object sender, EventArgs e)
        {
            var selectedRow = this.LVRanking.SelectedItems[0];
            var playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;

            using (var playerInfoForm = new PlayerNameForm(playerName, GetPlayerName(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerName(string playerName)
           => games.Where(x => x.Key.Item1 == playerName
               || x.Value.Any(y => y.Item1 == playerName))
           .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
               || x.Value.Any(y => y.Item1 == playerName))
           .ToList());
    }
}