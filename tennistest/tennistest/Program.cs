using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tennistest
{
    public partial class ScoreForm : Form
    {
        private Dictionary<string, int> playersWithPoints = new Dictionary<string, int>();
        private Dictionary<(string, int), List<(string, int)>> games = new Dictionary<(string, int), List<(string, int)>>();

        public ScoreForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.OnLoad);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(p => p.Value))
            {
                var item = new ListViewItem(player.Key);
                item.SubItems.Add(player.Value.ToString());
                listViewRanking.Items.Add(item);
            }
        }

        private void FillLatestGamesListView()
        {
            listViewLastestGames.Items.Clear();
            foreach (var game in games.Reverse())
            {
                FillListView(game.Key, game.Value);
            }
        }

        private void FillListView((string, int) firstPlayer, List<(string, int)> secondPlayers)
        {
            foreach (var secondPlayer in secondPlayers)
            {
                var winner = GetWinner(firstPlayer, secondPlayer);
                var item = new ListViewItem(new[] { firstPlayer.Item1, secondPlayer.Item1, winner, $"{firstPlayer.Item2}-{secondPlayer.Item2}" });
                listViewLastestGames.Items.Add(item);
            }
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2) return firstPlayer.Item1;
            if (firstPlayer.Item2 < secondPlayer.Item2) return secondPlayer.Item1;
            return "Draw";
        }

        private void buttonAddNewGame_Click(object sender, EventArgs e)
        {
            using (var newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    var firstPlayer = (newGameForm.FirstPlayerName, newGameForm.FirstPlayerPoints);
                    var secondPlayer = (newGameForm.SecondPlayerName, newGameForm.SecondPlayerPoints);
                    AddNewGame(firstPlayer, secondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (!games.ContainsKey(firstPlayer))
                games[firstPlayer] = new List<(string, int)>();
            games[firstPlayer].Add(secondPlayer);

            if (!games.ContainsKey(secondPlayer))
                games[secondPlayer] = new List<(string, int)>();
            games[secondPlayer].Add(firstPlayer);
        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
                playersWithPoints[player.Item1] += player.Item2;
            else
                playersWithPoints[player.Item1] = player.Item2;
        }
    }
}
