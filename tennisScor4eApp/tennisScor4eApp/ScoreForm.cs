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
        private static Dictionary<(string, int), List<(string, int)>> games = new();
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

            //  FillRankingLsitView();
            //FillLatestGamesView();
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
            // ne znam dali e ToList()
            foreach (var game in games.ToList())
            {
                foreach (var item in game.Value)
                {
                    //FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer,(string, int) secondPlayer)
        {
           // string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new ListViewItem();
            rollInLatestGamesListView.SubItems[0].Text =
        }
    }
}