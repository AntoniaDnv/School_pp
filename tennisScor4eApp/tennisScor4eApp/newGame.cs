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
    public partial class newGame : Form
    {
        public newGame()
        {
            InitializeComponent();
        }
        public (string, int) FirstPlayer { get; internal set; }
        public (string, int) SecondPlayer { get; internal set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstPlayer_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string firstPlayerName = txtFirstPlayer.Text;
            int firstPlayerPoints = (int)numericUpDownFirstPlayerPoints.Value;

            string secondPlayerName = txtSecondPlayer.Text;
            int secondPlayerPoints = (int)numericUpDownSecondPlayerPoints.Value;

            this.FirstPlayer = (firstPlayerName, firstPlayerPoints);
            this.SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;

        }

        private bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreSame()
            => txtFirstPlayer.Text == txtSecondPlayer.Text;

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrWhiteSpace(txtFirstPlayer.Text)
            || string.IsNullOrWhiteSpace(txtSecondPlayer.Text);

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessage(textBox);
                ShowErrorOnSameNames();
            }
        }

        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                labelSameNameErrorMessage.Text = "Player names should not be the same.";
            }
            else
            {
                labelSameNameErrorMessage.Text = string.Empty;
            }
        }

        private void RemoveErrorMessage(TextBox textBox)
        {
            if (textBox == this.txtFirstPlayer)
            {
                this.errorProviderFirstName.SetError(textBox, string.Empty);
                this.labelErrorFirstName.Text = string.Empty;
            }
            else if (textBox == this.txtSecondPlayer)
            {
                this.errorProviderSecondName.SetError(textBox, string.Empty);
                this.labelErrorSecondName.Text = string.Empty;
            }
        }

        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player name shoud not be blank";

            if (textBox == this.txtFirstPlayer)
            {
                this.errorProviderFirstName.SetError(textBox, errorText);
                this.labelErrorFirstName.Text = $"First {errorText}";
            }
            else if (textBox == this.txtSecondPlayer)
            {
                this.errorProviderSecondName.SetError(textBox, errorText);
                this.labelErrorSecondName.Text = $"Second {errorText}";
            }
        }
    }
}
