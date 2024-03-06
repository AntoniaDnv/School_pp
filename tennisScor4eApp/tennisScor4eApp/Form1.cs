namespace tennisScor4eApp
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, int> playersWithPoints = new();
        private static Dictionary<(string, int), List<(string, int)>> games = new();
        public Form1()
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
            //FillRankingLsitView();
            //FillLatestGamesView();
        }
        private void FillRankingLsitView()
        {
            this.LVRanking.Items.Clear();

        }
    }
}