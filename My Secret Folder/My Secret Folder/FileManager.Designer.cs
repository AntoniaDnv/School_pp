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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WelcomeLabel = new Label();
            FileNameLabel = new Label();
            InfoForFileLabel = new Label();
            FileNameValueLabel = new Label();
            FileTypeValueLabel = new Label();
            FileTypeLabel = new Label();
            deleteInfoLabel = new Label();
            backspaceInfoLabel = new Label();
            dragDropInfoLabel = new Label();
            butNewFolder = new Button();
            butUploadFile = new Button();
            butCreateTextFile = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            butBack = new Button();
            reverse = new Button();
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
            FileNameLabel.Location = new Point(49, 433);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(73, 20);
            FileNameLabel.TabIndex = 1;
            FileNameLabel.Text = "File Name";
            // 
            // InfoForFileLabel
            // 
            InfoForFileLabel.Anchor = AnchorStyles.Top;
            InfoForFileLabel.AutoSize = true;
            InfoForFileLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            InfoForFileLabel.Location = new Point(49, 313);
            InfoForFileLabel.Name = "InfoForFileLabel";
            InfoForFileLabel.Size = new Size(154, 23);
            InfoForFileLabel.TabIndex = 2;
            InfoForFileLabel.Text = "Label Info For File";
            InfoForFileLabel.Click += InfoForFileLabel_Click;
            // 
            // FileNameValueLabel
            // 
            FileNameValueLabel.Anchor = AnchorStyles.Top;
            FileNameValueLabel.AutoSize = true;
            FileNameValueLabel.Location = new Point(128, 433);
            FileNameValueLabel.Name = "FileNameValueLabel";
            FileNameValueLabel.Size = new Size(21, 20);
            FileNameValueLabel.TabIndex = 3;
            FileNameValueLabel.Text = "--";
            // 
            // FileTypeValueLabel
            // 
            FileTypeValueLabel.Anchor = AnchorStyles.Top;
            FileTypeValueLabel.AutoSize = true;
            FileTypeValueLabel.Location = new Point(697, 433);
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
            FileTypeLabel.Location = new Point(625, 433);
            FileTypeLabel.Name = "FileTypeLabel";
            FileTypeLabel.Size = new Size(66, 20);
            FileTypeLabel.TabIndex = 5;
            FileTypeLabel.Text = "File Type";
            // 
            // deleteInfoLabel
            // 
            deleteInfoLabel.Anchor = AnchorStyles.Top;
            deleteInfoLabel.AutoSize = true;
            deleteInfoLabel.Location = new Point(49, 344);
            deleteInfoLabel.Name = "deleteInfoLabel";
            deleteInfoLabel.Size = new Size(168, 20);
            deleteInfoLabel.TabIndex = 6;
            deleteInfoLabel.Text = "[DELETE] - deletes a file";
            // 
            // backspaceInfoLabel
            // 
            backspaceInfoLabel.Anchor = AnchorStyles.Top;
            backspaceInfoLabel.AutoSize = true;
            backspaceInfoLabel.Location = new Point(49, 367);
            backspaceInfoLabel.Name = "backspaceInfoLabel";
            backspaceInfoLabel.Size = new Size(279, 20);
            backspaceInfoLabel.TabIndex = 7;
            backspaceInfoLabel.Text = "[BACKSPACE] - moves the file backwards";
            // 
            // dragDropInfoLabel
            // 
            dragDropInfoLabel.Anchor = AnchorStyles.Top;
            dragDropInfoLabel.AutoSize = true;
            dragDropInfoLabel.Location = new Point(49, 387);
            dragDropInfoLabel.Name = "dragDropInfoLabel";
            dragDropInfoLabel.Size = new Size(296, 20);
            dragDropInfoLabel.TabIndex = 8;
            dragDropInfoLabel.Text = "[DRAG-DROP] - moves files into each other";
            // 
            // butNewFolder
            // 
            butNewFolder.Location = new Point(543, 344);
            butNewFolder.Name = "butNewFolder";
            butNewFolder.Size = new Size(116, 29);
            butNewFolder.TabIndex = 9;
            butNewFolder.Text = "New Folder";
            butNewFolder.UseVisualStyleBackColor = true;
            // 
            // butUploadFile
            // 
            butUploadFile.Location = new Point(421, 344);
            butUploadFile.Name = "butUploadFile";
            butUploadFile.Size = new Size(116, 29);
            butUploadFile.TabIndex = 10;
            butUploadFile.Text = "Upload File";
            butUploadFile.UseVisualStyleBackColor = true;
            // 
            // butCreateTextFile
            // 
            butCreateTextFile.Location = new Point(665, 344);
            butCreateTextFile.Name = "butCreateTextFile";
            butCreateTextFile.Size = new Size(146, 29);
            butCreateTextFile.TabIndex = 11;
            butCreateTextFile.Text = "Create Text File";
            butCreateTextFile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Location = new Point(94, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(631, 27);
            textBox1.TabIndex = 12;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Bisque;
            listView1.Location = new Point(94, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(631, 210);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "png.png");
            imageList1.Images.SetKeyName(1, "unknown.png");
            imageList1.Images.SetKeyName(2, "exe.png");
            imageList1.Images.SetKeyName(3, "folder.png");
            imageList1.Images.SetKeyName(4, "file.png");
            imageList1.Images.SetKeyName(5, "mp3.png");
            imageList1.Images.SetKeyName(6, "pdf.png");
            imageList1.Images.SetKeyName(7, "doc.png");
            imageList1.Images.SetKeyName(8, "zip.png");
            imageList1.Images.SetKeyName(9, "pptx.png");
            // 
            // butBack
            // 
            butBack.BackColor = Color.PowderBlue;
            butBack.Location = new Point(746, 64);
            butBack.Name = "butBack";
            butBack.Size = new Size(53, 36);
            butBack.TabIndex = 14;
            butBack.Text = "back";
            butBack.UseVisualStyleBackColor = false;
            // 
            // reverse
            // 
            reverse.BackColor = Color.PowderBlue;
            reverse.Location = new Point(12, 64);
            reverse.Name = "reverse";
            reverse.Size = new Size(76, 30);
            reverse.TabIndex = 15;
            reverse.Text = "Reverse";
            reverse.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(823, 492);
            Controls.Add(reverse);
            Controls.Add(butBack);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(butCreateTextFile);
            Controls.Add(butUploadFile);
            Controls.Add(butNewFolder);
            Controls.Add(dragDropInfoLabel);
            Controls.Add(backspaceInfoLabel);
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
        private Label backspaceInfoLabel;
        private Label dragDropInfoLabel;
        private Button butNewFolder;
        private Button butUploadFile;
        private Button butCreateTextFile;
        private TextBox textBox1;
        private ListView listView1;
        private ImageList imageList1;
        private Button butBack;
        private Button reverse;
    }
}