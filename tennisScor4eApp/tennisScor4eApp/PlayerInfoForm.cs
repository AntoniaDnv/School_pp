using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tennisScor4eApp
{
    public partial class PlayerNameForm : Form
    {
        public PlayerNameForm()
        {
            InitializeComponent();
        }

        private string playerName;
        private Dictionary<(string, int), List<(string, int)>> games = new Dictionary<(string, int), List<(string, int)>>();
        private (string, int) currentPlayer = new();
        private (string, int) competitor = new();

        public PlayerNameForm(string playerName, Dictionary<(string, int), List<(string, int)>> dictionary)
            : this()
        {
            this.games = dictionary;
            this.playerName = playerName;
            this.lblPlayerName.Text = playerName;

            FillVictoriesAndLossesListViews();
        }

        private void FillVictoriesAndLossesListViews()
        {
            ClearListViews();

            foreach (var game in this.games)
            {
                string firstPlayerName = game.Key.Item1;
                int firstPlayerPoints = game.Key.Item2;
                foreach (var item in game.Value)
                {
                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;

                    (this.currentPlayer, this.competitor) = GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPoints), (secondPlayerName, secondPlayerPoints));
                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
        {
            string competitorName = competitor.Item1;
            int currentPlayerPoints = this.currentPlayer.Item2;
            int competitorPoints = competitor.Item2;
            string score = $"{currentPlayerPoints} - {competitorPoints}";

            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);
        }

        private void AddDataToListView(string competitorName, string score, ListView currentListView)
        {
            var item = new ListViewItem();

            item.SubItems[0].Text = competitorName;
            item.SubItems.Add(score);
            currentListView.Items.Add(item);
        }

        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if (currentPlayerPoints > competitorPoints)
            {
                return this.lVVictories;
            }
            else if (currentPlayerPoints < competitorPoints)
            {
                return this.lVLosses;
            }

            return this.LVDraws;
        }

        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor(
            (string firstPlayerName, int firstPlayerPoints) value1,
            (string secondPlayerName, int secondPlayerPoints) value2)
        {
            if (value1.firstPlayerName == playerName)
            {
                return (value1, value2);
            }

            return (value2, value1);
        }

        private void ClearListViews()
        {
            this.LVDraws.Items.Clear();
            this.lVVictories.Items.Clear();
            this.lVLosses.Items.Clear();
        }
    }
}
