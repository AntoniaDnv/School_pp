namespace JSONtoCSV
{
    public partial class JsonToCsvForm : Form
    {
        public JsonToCsvForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RequestButtonClick(object sender, EventArgs e)
        {
            string userInput = $"{textBoxUserInput.Text}/";
        }
    }
}