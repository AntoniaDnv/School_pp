namespace project_vet_clinic
{
    partial class NewPetForm
    {
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.TextBox textBoxBreed;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelMedicalHistory;
        private System.Windows.Forms.TextBox textBoxMedicalHistory;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.RadioButton radioButtonDog;
        private System.Windows.Forms.Label labelFavToy;
        private System.Windows.Forms.TextBox textBoxFavToy;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Button buttonChooseImage;

        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelBreed = new Label();
            textBoxBreed = new TextBox();
            labelColor = new Label();
            textBoxColor = new TextBox();
            labelMedicalHistory = new Label();
            textBoxMedicalHistory = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelBirthday = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            radioButtonCat = new RadioButton();
            radioButtonDog = new RadioButton();
            labelFavToy = new Label();
            textBoxFavToy = new TextBox();
            buttonAdd = new Button();
            labelImage = new Label();
            textBoxImage = new TextBox();
            buttonChooseImage = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(150, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(30, 70);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(51, 20);
            labelBreed.TabIndex = 2;
            labelBreed.Text = "Breed:";
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(150, 70);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(200, 27);
            textBoxBreed.TabIndex = 3;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(30, 110);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(48, 20);
            labelColor.TabIndex = 4;
            labelColor.Text = "Color:";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(150, 110);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(200, 27);
            textBoxColor.TabIndex = 5;
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(30, 150);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(116, 20);
            labelMedicalHistory.TabIndex = 6;
            labelMedicalHistory.Text = "Medical History:";
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(150, 150);
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.Size = new Size(200, 27);
            textBoxMedicalHistory.TabIndex = 7;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(30, 190);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(59, 20);
            labelWeight.TabIndex = 8;
            labelWeight.Text = "Weight:";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(150, 190);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(200, 27);
            textBoxWeight.TabIndex = 9;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(30, 230);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(67, 20);
            labelBirthday.TabIndex = 10;
            labelBirthday.Text = "Birthday:";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(150, 230);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(200, 27);
            dateTimePickerBirthday.TabIndex = 11;
            // 
            // radioButtonCat
            // 
            radioButtonCat.AutoSize = true;
            radioButtonCat.Location = new Point(30, 270);
            radioButtonCat.Name = "radioButtonCat";
            radioButtonCat.Size = new Size(52, 24);
            radioButtonCat.TabIndex = 12;
            radioButtonCat.Text = "Cat";
            radioButtonCat.CheckedChanged += radioButtonCat_CheckedChanged;
            // 
            // radioButtonDog
            // 
            radioButtonDog.AutoSize = true;
            radioButtonDog.Location = new Point(150, 270);
            radioButtonDog.Name = "radioButtonDog";
            radioButtonDog.Size = new Size(59, 24);
            radioButtonDog.TabIndex = 13;
            radioButtonDog.Text = "Dog";
            radioButtonDog.CheckedChanged += radioButtonDog_CheckedChanged;
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Location = new Point(30, 310);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(91, 20);
            labelFavToy.TabIndex = 14;
            labelFavToy.Text = "Favorite Toy:";
            labelFavToy.Visible = false;
            // 
            // textBoxFavToy
            // 
            textBoxFavToy.Location = new Point(150, 310);
            textBoxFavToy.Name = "textBoxFavToy";
            textBoxFavToy.Size = new Size(200, 27);
            textBoxFavToy.TabIndex = 15;
            textBoxFavToy.Visible = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(150, 400);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 30);
            buttonAdd.TabIndex = 19;
            buttonAdd.Text = "Add Pet";
            buttonAdd.Click += btnAdd_Click;
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(30, 350);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(54, 20);
            labelImage.TabIndex = 16;
            labelImage.Text = "Image:";
            // 
            // textBoxImage
            // 
            textBoxImage.Location = new Point(150, 350);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.ReadOnly = true;
            textBoxImage.Size = new Size(200, 27);
            textBoxImage.TabIndex = 17;
            // 
            // buttonChooseImage
            // 
            buttonChooseImage.Location = new Point(370, 350);
            buttonChooseImage.Name = "buttonChooseImage";
            buttonChooseImage.Size = new Size(100, 27);
            buttonChooseImage.TabIndex = 18;
            buttonChooseImage.Text = "Choose...";
            buttonChooseImage.Click += btnChooseImage_Click;
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(500, 450);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelBreed);
            Controls.Add(textBoxBreed);
            Controls.Add(labelColor);
            Controls.Add(textBoxColor);
            Controls.Add(labelMedicalHistory);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(labelWeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelBirthday);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(radioButtonCat);
            Controls.Add(radioButtonDog);
            Controls.Add(labelFavToy);
            Controls.Add(textBoxFavToy);
            Controls.Add(labelImage);
            Controls.Add(textBoxImage);
            Controls.Add(buttonChooseImage);
            Controls.Add(buttonAdd);
            Name = "NewPetForm";
            Text = "Add New Pet";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
