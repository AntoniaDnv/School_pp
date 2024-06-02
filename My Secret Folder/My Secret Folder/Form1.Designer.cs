namespace My_Secret_Folder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeLabel = new Label();
            FileNameLabel = new Label();
            InfoForFileLabel = new Label();
            FileNameValueLabel = new Label();
            FileTypeValueLabel = new Label();
            FileTypeLabel = new Label();
            deleteInfoLabel = new Label();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.Top;
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(200, 19);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(390, 37);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to my secret folder";
            // 
            // FileNameLabel
            // 
            FileNameLabel.Anchor = AnchorStyles.Top;
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameLabel.Location = new Point(49, 388);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(73, 20);
            FileNameLabel.TabIndex = 1;
            FileNameLabel.Text = "File Name";
            // 
            // InfoForFileLabel
            // 
            InfoForFileLabel.Anchor = AnchorStyles.Top;
            InfoForFileLabel.AutoSize = true;
            InfoForFileLabel.Location = new Point(49, 258);
            InfoForFileLabel.Name = "InfoForFileLabel";
            InfoForFileLabel.Size = new Size(127, 20);
            InfoForFileLabel.TabIndex = 2;
            InfoForFileLabel.Text = "Label Info For File";
            // 
            // FileNameValueLabel
            // 
            FileNameValueLabel.Anchor = AnchorStyles.Top;
            FileNameValueLabel.AutoSize = true;
            FileNameValueLabel.Location = new Point(124, 390);
            FileNameValueLabel.Name = "FileNameValueLabel";
            FileNameValueLabel.Size = new Size(21, 20);
            FileNameValueLabel.TabIndex = 3;
            FileNameValueLabel.Text = "--";
            // 
            // FileTypeValueLabel
            // 
            FileTypeValueLabel.Anchor = AnchorStyles.Top;
            FileTypeValueLabel.AutoSize = true;
            FileTypeValueLabel.Location = new Point(695, 388);
            FileTypeValueLabel.Name = "FileTypeValueLabel";
            FileTypeValueLabel.Size = new Size(21, 20);
            FileTypeValueLabel.TabIndex = 4;
            FileTypeValueLabel.Text = "--";
            // 
            // FileTypeLabel
            // 
            FileTypeLabel.Anchor = AnchorStyles.Top;
            FileTypeLabel.AutoSize = true;
            FileTypeLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileTypeLabel.Location = new Point(623, 388);
            FileTypeLabel.Name = "FileTypeLabel";
            FileTypeLabel.Size = new Size(66, 20);
            FileTypeLabel.TabIndex = 5;
            FileTypeLabel.Text = "File Type";
            // 
            // deleteInfoLabel
            // 
            deleteInfoLabel.Anchor = AnchorStyles.Top;
            deleteInfoLabel.AutoSize = true;
            deleteInfoLabel.Location = new Point(49, 291);
            deleteInfoLabel.Name = "deleteInfoLabel";
            deleteInfoLabel.Size = new Size(168, 20);
            deleteInfoLabel.TabIndex = 6;
            deleteInfoLabel.Text = "[DELETE] - deletes a file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 492);
            Controls.Add(deleteInfoLabel);
            Controls.Add(FileTypeLabel);
            Controls.Add(FileTypeValueLabel);
            Controls.Add(FileNameValueLabel);
            Controls.Add(InfoForFileLabel);
            Controls.Add(FileNameLabel);
            Controls.Add(WelcomeLabel);
            Name = "Form1";
            Text = "File Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label FileNameLabel;
        private Label InfoForFileLabel;
        private Label FileNameValueLabel;
        private Label FileTypeValueLabel;
        private Label FileTypeLabel;
        private Label deleteInfoLabel;
    }
}