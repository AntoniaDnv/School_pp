namespace My_Secret_Folder
{
    partial class NewFile
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
            label1 = new Label();
            butSave = new Button();
            butOpenManager = new Button();
            richTextBox1 = new RichTextBox();
            errorProvider = new ErrorProvider(components);
            labelInvalidText = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 20);
            label1.Name = "label1";
            label1.Size = new Size(457, 46);
            label1.TabIndex = 0;
            label1.Text = "Upload your new secret file";
            // 
            // butSave
            // 
            butSave.BackColor = Color.CadetBlue;
            butSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            butSave.ForeColor = SystemColors.ButtonFace;
            butSave.Location = new Point(614, 185);
            butSave.Name = "butSave";
            butSave.Size = new Size(149, 65);
            butSave.TabIndex = 5;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = false;
            // 
            // butOpenManager
            // 
            butOpenManager.BackColor = Color.CadetBlue;
            butOpenManager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            butOpenManager.ForeColor = SystemColors.ButtonFace;
            butOpenManager.Location = new Point(614, 312);
            butOpenManager.Name = "butOpenManager";
            butOpenManager.Size = new Size(149, 78);
            butOpenManager.TabIndex = 6;
            butOpenManager.Text = "Open File Manager";
            butOpenManager.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DarkGray;
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Location = new Point(109, 157);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(398, 237);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // labelInvalidText
            // 
            labelInvalidText.AutoSize = true;
            labelInvalidText.Location = new Point(53, 63);
            labelInvalidText.Name = "labelInvalidText";
            labelInvalidText.Size = new Size(0, 20);
            labelInvalidText.TabIndex = 8;
            // 
            // NewFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInvalidText);
            Controls.Add(richTextBox1);
            Controls.Add(butOpenManager);
            Controls.Add(butSave);
            Controls.Add(label1);
            Name = "NewFile";
            Text = "NewFile";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butSave;
        private Button butOpenManager;
        private RichTextBox richTextBox1;
        private ErrorProvider errorProvider;
        private Label labelInvalidText;
    }
}