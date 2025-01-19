namespace project_vet_clinic
{
    partial class PetDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBreed;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxMedicalHistory;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxFavToy;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelMedicalHistory;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelFavToy;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Button buttonAdopt;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetDetailsForm));
            textBoxName = new TextBox();
            textBoxBreed = new TextBox();
            textBoxColor = new TextBox();
            textBoxMedicalHistory = new TextBox();
            textBoxWeight = new TextBox();
            textBoxBirthday = new TextBox();
            textBoxStatus = new TextBox();
            textBoxFavToy = new TextBox();
            labelName = new Label();
            labelBreed = new Label();
            labelColor = new Label();
            labelMedicalHistory = new Label();
            labelWeight = new Label();
            labelBirthday = new Label();
            labelStatus = new Label();
            labelFavToy = new Label();
            pictureBoxPet = new PictureBox();
            buttonAdopt = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPet).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(300, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(150, 335);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.ReadOnly = true;
            textBoxBreed.Size = new Size(200, 27);
            textBoxBreed.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(556, 180);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(200, 27);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(150, 381);
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.ReadOnly = true;
            textBoxMedicalHistory.Size = new Size(200, 27);
            textBoxMedicalHistory.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(556, 140);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.ReadOnly = true;
            textBoxWeight.Size = new Size(200, 27);
            textBoxWeight.TabIndex = 5;
            // 
            // textBoxBirthday
            // 
            textBoxBirthday.Location = new Point(150, 288);
            textBoxBirthday.Name = "textBoxBirthday";
            textBoxBirthday.ReadOnly = true;
            textBoxBirthday.Size = new Size(200, 27);
            textBoxBirthday.TabIndex = 6;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(556, 271);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(200, 27);
            textBoxStatus.TabIndex = 7;
            // 
            // textBoxFavToy
            // 
            textBoxFavToy.Location = new Point(556, 223);
            textBoxFavToy.Name = "textBoxFavToy";
            textBoxFavToy.ReadOnly = true;
            textBoxFavToy.Size = new Size(200, 27);
            textBoxFavToy.TabIndex = 8;
            textBoxFavToy.Visible = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(242, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 9;
            labelName.Text = "Name:";
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(89, 338);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(51, 20);
            labelBreed.TabIndex = 10;
            labelBreed.Text = "Breed:";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(502, 187);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(48, 20);
            labelColor.TabIndex = 11;
            labelColor.Text = "Color:";
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(24, 384);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(116, 20);
            labelMedicalHistory.TabIndex = 12;
            labelMedicalHistory.Text = "Medical History:";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(491, 147);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(59, 20);
            labelWeight.TabIndex = 13;
            labelWeight.Text = "Weight:";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(74, 295);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(67, 20);
            labelBirthday.TabIndex = 14;
            labelBirthday.Text = "Birthday:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(481, 274);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 15;
            labelStatus.Text = "Status:";
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Location = new Point(459, 226);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(91, 20);
            labelFavToy.TabIndex = 16;
            labelFavToy.Text = "Favorite Toy:";
            labelFavToy.Visible = false;
            // 
            // pictureBoxPet
            // 
            pictureBoxPet.BackColor = Color.Orange;
            pictureBoxPet.Image = (Image)resources.GetObject("pictureBoxPet.Image");
            pictureBoxPet.Location = new Point(74, 40);
            pictureBoxPet.Name = "pictureBoxPet";
            pictureBoxPet.Size = new Size(150, 150);
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPet.TabIndex = 17;
            pictureBoxPet.TabStop = false;
            // 
            // buttonAdopt
            // 
            buttonAdopt.BackColor = Color.RoyalBlue;
            buttonAdopt.Location = new Point(556, 335);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(150, 48);
            buttonAdopt.TabIndex = 18;
            buttonAdopt.Text = "Adopt";
            buttonAdopt.UseVisualStyleBackColor = false;
            buttonAdopt.Click += buttonAdopt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 241);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 20;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // PetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(823, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxBreed);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBirthday);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxFavToy);
            Controls.Add(labelName);
            Controls.Add(labelBreed);
            Controls.Add(labelColor);
            Controls.Add(labelMedicalHistory);
            Controls.Add(labelWeight);
            Controls.Add(labelBirthday);
            Controls.Add(labelStatus);
            Controls.Add(labelFavToy);
            Controls.Add(pictureBoxPet);
            Controls.Add(buttonAdopt);
            Name = "PetDetailsForm";
            Text = "Pet Details";
            Load += PetDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
    }
}
