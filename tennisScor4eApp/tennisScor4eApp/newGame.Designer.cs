﻿namespace tennisScor4eApp
{
    partial class newGame
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
            lblNewGame = new Label();
            lblFirstPlayer = new Label();
            lblSecondPlayer = new Label();
            lblpoints1 = new Label();
            points2 = new Label();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            butSave = new Button();
            lblVS = new Label();
            txtFirstPlayer = new TextBox();
            txtSecondPlayer = new TextBox();
            errorProviderFirstName = new ErrorProvider(components);
            errorProviderSecondName = new ErrorProvider(components);
            labelErrorFirstName = new Label();
            labelErrorSecondName = new Label();
            labelSameNameErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondName).BeginInit();
            SuspendLayout();
            // 
            // lblNewGame
            // 
            lblNewGame.Anchor = AnchorStyles.Top;
            lblNewGame.AutoSize = true;
            lblNewGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewGame.Location = new Point(321, 21);
            lblNewGame.Name = "lblNewGame";
            lblNewGame.RightToLeft = RightToLeft.No;
            lblNewGame.Size = new Size(160, 38);
            lblNewGame.TabIndex = 0;
            lblNewGame.Text = "New Game";
            lblNewGame.Click += label1_Click;
            // 
            // lblFirstPlayer
            // 
            lblFirstPlayer.AutoSize = true;
            lblFirstPlayer.Location = new Point(77, 113);
            lblFirstPlayer.Name = "lblFirstPlayer";
            lblFirstPlayer.Size = new Size(80, 20);
            lblFirstPlayer.TabIndex = 1;
            lblFirstPlayer.Text = "First Player";
            // 
            // lblSecondPlayer
            // 
            lblSecondPlayer.AutoSize = true;
            lblSecondPlayer.Location = new Point(557, 112);
            lblSecondPlayer.Name = "lblSecondPlayer";
            lblSecondPlayer.Size = new Size(102, 20);
            lblSecondPlayer.TabIndex = 2;
            lblSecondPlayer.Text = "Second Player";
            // 
            // lblpoints1
            // 
            lblpoints1.AutoSize = true;
            lblpoints1.Location = new Point(84, 227);
            lblpoints1.Name = "lblpoints1";
            lblpoints1.Size = new Size(50, 20);
            lblpoints1.TabIndex = 3;
            lblpoints1.Text = "points";
            // 
            // points2
            // 
            points2.AutoSize = true;
            points2.Location = new Point(564, 235);
            points2.Name = "points2";
            points2.Size = new Size(50, 20);
            points2.TabIndex = 4;
            points2.Text = "points";
            points2.Click += label5_Click;
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.BackColor = Color.Coral;
            numericUpDownFirstPlayerPoints.Location = new Point(84, 258);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(50, 27);
            numericUpDownFirstPlayerPoints.TabIndex = 3;
            numericUpDownFirstPlayerPoints.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.BackColor = Color.Coral;
            numericUpDownSecondPlayerPoints.Location = new Point(564, 263);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(50, 27);
            numericUpDownSecondPlayerPoints.TabIndex = 4;
            // 
            // butSave
            // 
            butSave.Location = new Point(341, 344);
            butSave.Name = "butSave";
            butSave.Size = new Size(94, 29);
            butSave.TabIndex = 5;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = true;
            // 
            // lblVS
            // 
            lblVS.Anchor = AnchorStyles.Top;
            lblVS.AutoSize = true;
            lblVS.Font = new Font("Javanese Text", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVS.Location = new Point(341, 227);
            lblVS.Name = "lblVS";
            lblVS.RightToLeft = RightToLeft.No;
            lblVS.Size = new Size(84, 84);
            lblVS.TabIndex = 8;
            lblVS.Text = "VS";
            // 
            // txtFirstPlayer
            // 
            txtFirstPlayer.BackColor = Color.Coral;
            txtFirstPlayer.Location = new Point(77, 142);
            txtFirstPlayer.Name = "txtFirstPlayer";
            txtFirstPlayer.Size = new Size(125, 27);
            txtFirstPlayer.TabIndex = 1;
            txtFirstPlayer.TextChanged += txtFirstPlayer_TextChanged;
            // 
            // txtSecondPlayer
            // 
            txtSecondPlayer.BackColor = Color.Coral;
            txtSecondPlayer.Location = new Point(557, 142);
            txtSecondPlayer.Name = "txtSecondPlayer";
            txtSecondPlayer.Size = new Size(125, 27);
            txtSecondPlayer.TabIndex = 2;
            // 
            // errorProviderFirstName
            // 
            errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderSecondName
            // 
            errorProviderSecondName.ContainerControl = this;
            // 
            // labelErrorFirstName
            // 
            labelErrorFirstName.AutoSize = true;
            labelErrorFirstName.Location = new Point(77, 172);
            labelErrorFirstName.Name = "labelErrorFirstName";
            labelErrorFirstName.Size = new Size(50, 20);
            labelErrorFirstName.TabIndex = 9;
            labelErrorFirstName.Text = "label1";
            // 
            // labelErrorSecondName
            // 
            labelErrorSecondName.AutoSize = true;
            labelErrorSecondName.Location = new Point(561, 174);
            labelErrorSecondName.Name = "labelErrorSecondName";
            labelErrorSecondName.Size = new Size(50, 20);
            labelErrorSecondName.TabIndex = 10;
            labelErrorSecondName.Text = "label1";
            // 
            // labelSameNameErrorMessage
            // 
            labelSameNameErrorMessage.AutoSize = true;
            labelSameNameErrorMessage.Location = new Point(93, 377);
            labelSameNameErrorMessage.Name = "labelSameNameErrorMessage";
            labelSameNameErrorMessage.Size = new Size(50, 20);
            labelSameNameErrorMessage.TabIndex = 11;
            labelSameNameErrorMessage.Text = "label1";
            // 
            // newGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSameNameErrorMessage);
            Controls.Add(labelErrorSecondName);
            Controls.Add(labelErrorFirstName);
            Controls.Add(txtSecondPlayer);
            Controls.Add(txtFirstPlayer);
            Controls.Add(lblVS);
            Controls.Add(butSave);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(points2);
            Controls.Add(lblpoints1);
            Controls.Add(lblSecondPlayer);
            Controls.Add(lblFirstPlayer);
            Controls.Add(lblNewGame);
            Name = "newGame";
            Text = "newGame";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewGame;
        private Label lblFirstPlayer;
        private Label lblSecondPlayer;
        private Label lblpoints1;
        private Label points2;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private Button butSave;
        private Label lblVS;
        private TextBox txtFirstPlayer;
        private TextBox txtSecondPlayer;
        private ErrorProvider errorProviderFirstName;
        private ErrorProvider errorProviderSecondName;
        private Label labelSameNameErrorMessage;
        private Label labelErrorSecondName;
        private Label labelErrorFirstName;
    }
}