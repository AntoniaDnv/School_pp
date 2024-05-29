using System.Security.Cryptography.X509Certificates;

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
                JsonToCsv.CheckUserInput(userInput);
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message, "Error");
                return;
            }

            try
            {
                textBoxJson.Text = JsonToCsv.GetJson(userInput);

            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message, "Error");
            }

        }
        public void DisplayInvalidInputMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void labelUrl_Click(object sender, EventArgs e)
        {

        }

        private void JsonTextBoxTextChanged(object sender, EventArgs e)
        {
            if(textBoxJson.Text != string.Empty)
            {
                btnConvert.Visible = true;
                btnConvert.Focus();
            }
        }
    }
}