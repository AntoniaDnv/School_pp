namespace My_Secret_Folder
{
    partial class NewTextFileForm
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
            labelSecretFile = new Label();
            labelFileName = new Label();
            labelFileContent = new Label();
            richTextBox1 = new RichTextBox();
            butSave = new Button();
            textBox1 = new TextBox();
            errorProviderText = new ErrorProvider(components);
            errorProviderFileName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).BeginInit();
            SuspendLayout();
            // 
            // labelSecretFile
            // 
            labelSecretFile.AutoSize = true;
            labelSecretFile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelSecretFile.Location = new Point(158, 43);
            labelSecretFile.Name = "labelSecretFile";
            labelSecretFile.Size = new Size(472, 46);
            labelSecretFile.TabIndex = 0;
            labelSecretFile.Text = "Upload Your New Secret File";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFileName.Location = new Point(602, 169);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(149, 28);
            labelFileName.TabIndex = 1;
            labelFileName.Text = "Enter File Name";
            // 
            // labelFileContent
            // 
            labelFileContent.AutoSize = true;
            labelFileContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFileContent.Location = new Point(53, 169);
            labelFileContent.Name = "labelFileContent";
            labelFileContent.Size = new Size(167, 28);
            labelFileContent.TabIndex = 2;
            labelFileContent.Text = "Enter File Content";
            labelFileContent.Click += labelFileContent_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Bisque;
            richTextBox1.Location = new Point(53, 200);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(461, 199);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // butSave
            // 
            butSave.BackColor = Color.CadetBlue;
            butSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            butSave.ForeColor = SystemColors.ButtonFace;
            butSave.Location = new Point(602, 319);
            butSave.Name = "butSave";
            butSave.Size = new Size(149, 65);
            butSave.TabIndex = 4;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Location = new Point(602, 200);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 56);
            textBox1.TabIndex = 5;
            // 
            // errorProviderText
            // 
            errorProviderText.ContainerControl = this;
            // 
            // errorProviderFileName
            // 
            errorProviderFileName.ContainerControl = this;
            // 
            // NewTextFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(butSave);
            Controls.Add(richTextBox1);
            Controls.Add(labelFileContent);
            Controls.Add(labelFileName);
            Controls.Add(labelSecretFile);
            Name = "NewTextFileForm";
            Text = "NewTextFileForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecretFile;
        private Label labelFileName;
        private Label labelFileContent;
        private RichTextBox richTextBox1;
        private Button butSave;
        private TextBox textBox1;
        private ErrorProvider errorProviderText;
        private ErrorProvider errorProviderFileName;
    }
}