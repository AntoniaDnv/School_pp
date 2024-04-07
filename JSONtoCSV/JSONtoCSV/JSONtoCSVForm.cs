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

            try
            {
               // JsonToCsv.CheckUserInput(userInput);
            }
            catch (Exception ex)
            {
               //DisplayInvalidInputMessage(ex.Message, "Error");
                return;
            }

            try
            {
                //textBoxJson.Text = JsonToCsv.GetJson(userInput);

            }
            catch (Exception ex) 
            {
               // DisplayInvalidInputMessage(ex.Message, "Error");
            }
        }
    }
}