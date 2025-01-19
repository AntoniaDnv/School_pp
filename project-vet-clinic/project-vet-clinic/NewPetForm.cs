using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_vet_clinic
{
    public partial class NewPetForm : Form
    {
        private string petImage = string.Empty;
        public IAnimal NewPet { get; private set; }

        public NewPetForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
                return;

            NewPet = CreateNewAnimal();
            if (NewPet != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool CheckIfInputsAreValid()
        {
            bool isValid = true;

            isValid &= CheckIfValid(textBoxName, 3, labelNameError);
            isValid &= CheckIfValid(textBoxBreed, 3, labelBreedError);
            isValid &= CheckIfValid(textBoxColor, 3, labelColorError);
            isValid &= CheckIfValid(textBoxMedicalHistory, 10, labelHistoryError);
            isValid &= CheckIfValidDouble(textBoxWeight, labelWeightError, 0.5);
            isValid &= CheckIfNotEmpty(petImage, labelImageError);

            if (radioButtonCat.Checked)
            {
                isValid &= CheckIfValid(textBoxFavToy, 3, labelToyError);
            }

            return isValid;
        }

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            if (double.TryParse(textBox.Text, out double value) && value >= min)
            {
                ShowValidationError(errorLabel, true);
                return true;
            }

            ShowValidationError(errorLabel, false);
            return false;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value);
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private IAnimal CreateNewAnimal()
        {
            string name = textBoxName.Text;
            DateTime birthday = dateTimePickerBirthday.Value;
            string breed = textBoxBreed.Text;
            string medicalHistory = textBoxMedicalHistory.Text;
            double weight = double.Parse(textBoxWeight.Text);
            string color = textBoxColor.Text;

            if (radioButtonCat.Checked)
            {
                return CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else if (radioButtonDog.Checked)
            {
                return CreateDog(name, birthday, breed, medicalHistory, weight, color);
            }

            return null;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favoriteToy = textBoxFavToy.Text;
            return new Cat(name, birthday, breed, medicalHistory, weight, color, favoriteToy, petImage);
        }

        private Dog CreateDog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            return new Dog(name, birthday, breed, medicalHistory, weight, color, petImage);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Pet Image"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                petImage = dialog.FileName;
                textBoxImage.Text = Path.GetFileName(petImage);
            }
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = textBoxFavToy.Visible = radioButtonCat.Checked;
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = textBoxFavToy.Visible = radioButtonCat.Checked;
        }
    }

}
