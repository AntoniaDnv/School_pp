namespace My_Secret_Folder
{
    partial class NewFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            labelFolderName = new Label();
            textBox1 = new TextBox();
            butEnter = new Button();
            errorProviderForFolderName = new ErrorProvider(components);
            labelErrorProvider = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderForFolderName).BeginInit();
            SuspendLayout();
            // 
            // labelFolderName
            // 
            labelFolderName.AutoSize = true;
            labelFolderName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelFolderName.Location = new Point(328, 54);
            labelFolderName.Margin = new Padding(4, 0, 4, 0);
            labelFolderName.Name = "labelFolderName";
            labelFolderName.Size = new Size(427, 46);
            labelFolderName.TabIndex = 0;
            labelFolderName.Text = "Please Enter Folder Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Location = new Point(273, 187);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(541, 49);
            textBox1.TabIndex = 1;
            // 
            // butEnter
            // 
            butEnter.BackColor = Color.CadetBlue;
            butEnter.ForeColor = SystemColors.ButtonHighlight;
            butEnter.Location = new Point(409, 326);
            butEnter.Margin = new Padding(4, 4, 4, 4);
            butEnter.Name = "butEnter";
            butEnter.Size = new Size(260, 69);
            butEnter.TabIndex = 2;
            butEnter.Text = "Enter";
            butEnter.UseVisualStyleBackColor = false;
            // 
            // errorProviderForFolderName
            // 
            errorProviderForFolderName.ContainerControl = this;
            // 
            // labelErrorProvider
            // 
            labelErrorProvider.AutoSize = true;
            labelErrorProvider.Location = new Point(108, 134);
            labelErrorProvider.Name = "labelErrorProvider";
            labelErrorProvider.Size = new Size(0, 25);
            labelErrorProvider.TabIndex = 3;
            // 
            // NewFolder
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 562);
            Controls.Add(labelErrorProvider);
            Controls.Add(butEnter);
            Controls.Add(textBox1);
            Controls.Add(labelFolderName);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NewFolder";
            Text = "NewFolder";
            ((System.ComponentModel.ISupportInitialize)errorProviderForFolderName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFolderName;
        private TextBox textBox1;
        private Button butEnter;
        private ErrorProvider errorProviderForFolderName;
        private Label labelErrorProvider;
    }
}