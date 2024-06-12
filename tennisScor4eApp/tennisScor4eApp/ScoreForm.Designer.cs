namespace tennisScor4eApp
{
    partial class ScoreForm
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
        /* private void InitializeComponent()
         {
             // in the instruction it says the method is commented for now 
             Load += OnLoad;
             ResumeLayout(false);
             PerformLayout();
         } */

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRanking = new Label();
            lblTennisHeading = new Label();
            label2 = new Label();
            LVRanking = new ListView();
            Form1 = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            label1 = new Label();
            btnAddNewGame = new Button();
            LVLatestGames = new ListView();
            colFirstPlayer = new ColumnHeader();
            colSecondPlayer = new ColumnHeader();
            colWinner = new ColumnHeader();
            colScore = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblRanking
            // 
            lblRanking.Anchor = AnchorStyles.Top;
            lblRanking.AutoSize = true;
            lblRanking.Location = new Point(17, 79);
            lblRanking.Name = "lblRanking";
            lblRanking.Size = new Size(62, 20);
            lblRanking.TabIndex = 0;
            lblRanking.Text = "Ranking";
            // 
            // lblTennisHeading
            // 
            lblTennisHeading.Anchor = AnchorStyles.Top;
            lblTennisHeading.AutoSize = true;
            lblTennisHeading.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTennisHeading.Location = new Point(303, 21);
            lblTennisHeading.Name = "lblTennisHeading";
            lblTennisHeading.Size = new Size(188, 33);
            lblTennisHeading.TabIndex = 1;
            lblTennisHeading.Text = "Tennis Score";
            lblTennisHeading.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(17, 262);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Ranking";
            // 
            // LVRanking
            // 
            LVRanking.BackColor = Color.Coral;
            LVRanking.Columns.AddRange(new ColumnHeader[] { Form1, scoreColumn });
            LVRanking.Location = new Point(17, 102);
            LVRanking.Name = "LVRanking";
            LVRanking.Size = new Size(771, 107);
            LVRanking.TabIndex = 3;
            LVRanking.UseCompatibleStateImageBehavior = false;
            LVRanking.View = View.Details;
            // 
            // Form1
            // 
            Form1.Name = "Form1";
            Form1.Text = "Palyer Name";
            Form1.Width = 110;
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(17, 290);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Latest Game";
            // 
            // btnAddNewGame
            // 
            btnAddNewGame.Location = new Point(636, 215);
            btnAddNewGame.Name = "btnAddNewGame";
            btnAddNewGame.Size = new Size(141, 29);
            btnAddNewGame.TabIndex = 5;
            btnAddNewGame.Text = "Add New Game";
            btnAddNewGame.UseVisualStyleBackColor = true;
            btnAddNewGame.Click += AddNewGameButtonClick;
            // 
            // LVLatestGames
            // 
            LVLatestGames.BackColor = Color.Coral;
            LVLatestGames.Columns.AddRange(new ColumnHeader[] { colFirstPlayer, colSecondPlayer, colWinner, colScore });
            LVLatestGames.Location = new Point(17, 313);
            LVLatestGames.Name = "LVLatestGames";
            LVLatestGames.Size = new Size(771, 121);
            LVLatestGames.TabIndex = 7;
            LVLatestGames.UseCompatibleStateImageBehavior = false;
            LVLatestGames.View = View.Details;
            // 
            // colFirstPlayer
            // 
            colFirstPlayer.Text = "First Player";
            colFirstPlayer.Width = 90;
            // 
            // colSecondPlayer
            // 
            colSecondPlayer.Text = "Second Player";
            colSecondPlayer.Width = 110;
            // 
            // colWinner
            // 
            colWinner.Text = "Winner";
            // 
            // colScore
            // 
            colScore.Text = "Score";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(17, 212);
            label3.Name = "label3";
            label3.Size = new Size(237, 20);
            label3.TabIndex = 8;
            label3.Text = "*click on button to add new player";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(LVLatestGames);
            Controls.Add(btnAddNewGame);
            Controls.Add(label1);
            Controls.Add(LVRanking);
            Controls.Add(label2);
            Controls.Add(lblTennisHeading);
            Controls.Add(lblRanking);
            ForeColor = SystemColors.ControlText;
            Name = "ScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRanking;
        private Label lblTennisHeading;
        private Label label2;
        private ListView LVRanking;
        private ColumnHeader palyerNameColumn;
        private ColumnHeader scoreColumn;
        private Label label1;
        private Button btnAddNewGame;
        private ListView LVLatestGames;
        private ColumnHeader colFirstPlayer;
        private ColumnHeader colSecondPlayer;
        private ColumnHeader colWinner;
        private ColumnHeader colScore;
        private Label label3;
        private ColumnHeader Form1;
    }
}