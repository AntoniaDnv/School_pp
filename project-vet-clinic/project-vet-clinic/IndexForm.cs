namespace project_vet_clinic
{
    public partial class IndexForm : Form
    {
        private List<IAnimal> animals = StartUp.GetInitialAnimals();

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            listViewPets.Items.Clear();
            foreach (var pet in animals)
            {
                var item = new ListViewItem(pet.Name)
                {
                    ImageIndex = pet is Cat ? 0 : 1 // Use different icons for Cat/Dog
                };
                listViewPets.Items.Add(item);
            }
        }

        private void listViewPets_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewPets.SelectedIndices.Count == 0) return;
            var selectedPet = animals[listViewPets.SelectedIndices[0]];

            using var detailsForm = new PetDetailsForm(selectedPet);
            detailsForm.ShowDialog();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            using var addForm = new NewPetForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                animals.Add(addForm.NewPet);
                LoadAllPets();
            }
        }
    }


}
