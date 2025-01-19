using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace project_vet_clinic
{
    public partial class PetDetailsForm : Form
    {
        private readonly IAnimal pet;

        public PetDetailsForm(IAnimal selectedPet)
        {
            pet = selectedPet;
            InitializeComponent();
        }

        private void PetDetailsForm_Load(object sender, EventArgs e)
        {
            FillPetInfo();
        }

        private void FillPetInfo()
        {
            textBoxName.Text = pet.Name;
            textBoxBreed.Text = pet.Breed;
            textBoxColor.Text = pet.Color;
            textBoxMedicalHistory.Text = pet.MedicalHistory;
            textBoxWeight.Text = pet.Weight.ToString();
            textBoxBirthday.Text = pet.Birthday.ToShortDateString();
            textBoxStatus.Text = pet.AdoptionStatus.ToString();

            if (pet is Cat cat)
            {
                textBoxFavToy.Text = cat.FavoriteToy;
                labelFavToy.Visible = textBoxFavToy.Visible = true;
            }
            else
            {
                labelFavToy.Visible = textBoxFavToy.Visible = false;
            }

            if (!string.IsNullOrEmpty(pet.ImagePath) && File.Exists(pet.ImagePath))
            {
                pictureBoxPet.Image = Image.FromFile(pet.ImagePath);
            }

            buttonAdopt.Enabled = pet.AdoptionStatus == Status.NotAdopted;
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            pet.AdoptionStatus = Status.Adopted;
            textBoxStatus.Text = pet.AdoptionStatus.ToString();
            buttonAdopt.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
