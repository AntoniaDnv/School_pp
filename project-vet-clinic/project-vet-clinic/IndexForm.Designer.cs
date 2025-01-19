using System.Drawing;

namespace project_vet_clinic
{
    partial class IndexForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button buttonAddPet;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddPet = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(188, 32);
            this.labelTitle.Text = "Vet Clinic - Pets";

            // listViewPets
            this.listViewPets.LargeImageList = this.imageListIcons;
            this.listViewPets.Location = new System.Drawing.Point(20, 70);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(400, 300);
            this.listViewPets.View = System.Windows.Forms.View.LargeIcon;
            this.listViewPets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPets_MouseClick);

            // imageListIcons
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcons.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;

            // buttonAddPet
            this.buttonAddPet.Location = new System.Drawing.Point(20, 400);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(150, 40);
            this.buttonAddPet.Text = "Add New Pet";
            this.buttonAddPet.UseVisualStyleBackColor = true;
            this.buttonAddPet.Click += new System.EventHandler(this.btnAddPet_Click);

            // IndexForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.buttonAddPet);
            this.Name = "IndexForm";
            this.Text = "Vet Clinic - Main";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
