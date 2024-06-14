namespace tennisScor4eApp
{
    partial class PlayerNameForm
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
            lblPlayerName = new Label();
            lblLosses = new Label();
            lblVictories = new Label();
            lblDraws = new Label();
            lVVictories = new ListView();
            colVictoryCompetitor = new ColumnHeader();
            colVictoryScore = new ColumnHeader();
            lVLosses = new ListView();
            colLosesPlayer = new ColumnHeader();
            colLosesScore = new ColumnHeader();
            LVDraws = new ListView();
            colDrawPlayer = new ColumnHeader();
            colDrawScore = new ColumnHeader();
            SuspendLayout();
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayerName.Location = new Point(306, 9);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(190, 38);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Player Name";
           
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.Location = new Point(306, 157);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new Size(51, 20);
            lblLosses.TabIndex = 1;
            lblLosses.Text = "Losses";
            // 
            // lblVictories
            // 
            lblVictories.AutoSize = true;
            lblVictories.Location = new Point(36, 152);
            lblVictories.Name = "lblVictories";
            lblVictories.Size = new Size(66, 20);
            lblVictories.TabIndex = 2;
            lblVictories.Text = "Victories";
            // 
            // lblDraws
            // 
            lblDraws.AutoSize = true;
            lblDraws.Location = new Point(561, 157);
            lblDraws.Name = "lblDraws";
            lblDraws.Size = new Size(50, 20);
            lblDraws.TabIndex = 3;
            lblDraws.Text = "Draws";
            
            // 
            // lVVictories
            // 
            lVVictories.BackColor = Color.Coral;
            lVVictories.Columns.AddRange(new ColumnHeader[] { colVictoryCompetitor, colVictoryScore });
            lVVictories.Location = new Point(36, 180);
            lVVictories.Name = "lVVictories";
            lVVictories.Size = new Size(218, 121);
            lVVictories.TabIndex = 4;
            lVVictories.UseCompatibleStateImageBehavior = false;
            lVVictories.View = View.Details;
            // 
            // colVictoryCompetitor
            // 
            colVictoryCompetitor.Text = "Victory Competitor";
            colVictoryCompetitor.Width = 150;
            // 
            // colVictoryScore
            // 
            colVictoryScore.Text = "Score";
            colVictoryScore.Width = 80;
            // 
            // lVLosses
            // 
            lVLosses.BackColor = Color.Coral;
            lVLosses.Columns.AddRange(new ColumnHeader[] { colLosesPlayer, colLosesScore });
            lVLosses.Location = new Point(306, 180);
            lVLosses.Name = "lVLosses";
            lVLosses.Size = new Size(210, 121);
            lVLosses.TabIndex = 5;
            lVLosses.UseCompatibleStateImageBehavior = false;
            lVLosses.View = View.Details;
            // 
            // colLosesPlayer
            // 
            colLosesPlayer.Text = "Competitor";
            colLosesPlayer.Width = 150;
            // 
            // colLosesScore
            // 
            colLosesScore.Text = "Score";
            colLosesScore.Width = 80;
            // 
            // LVDraws
            // 
            LVDraws.BackColor = Color.Coral;
            LVDraws.Columns.AddRange(new ColumnHeader[] { colDrawPlayer, colDrawScore });
            LVDraws.Location = new Point(561, 180);
            LVDraws.Name = "LVDraws";
            LVDraws.Size = new Size(208, 121);
            LVDraws.TabIndex = 6;
            LVDraws.UseCompatibleStateImageBehavior = false;
            LVDraws.View = View.Details;
            // 
            // colDrawPlayer
            // 
            colDrawPlayer.Text = "Competitor";
            colDrawPlayer.Width = 150;
            // 
            // colDrawScore
            // 
            colDrawScore.Text = "Score";
            colDrawScore.Width = 80;
            // 
            // PlayerNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(LVDraws);
            Controls.Add(lVLosses);
            Controls.Add(lVVictories);
            Controls.Add(lblDraws);
            Controls.Add(lblVictories);
            Controls.Add(lblLosses);
            Controls.Add(lblPlayerName);
            ForeColor = SystemColors.ControlText;
            Name = "PlayerNameForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerName;
        private Label lblLosses;
        private Label lblVictories;
        private Label lblDraws;
        private ListView lVVictories;
        private ColumnHeader colVictoryCompetitor;
        private ColumnHeader colVictoryScore;
        private ListView lVLosses;
        private ColumnHeader colLosesPlayer;
        private ColumnHeader colLosesScore;
        private ListView LVDraws;
        private ColumnHeader colDrawPlayer;
        private ColumnHeader colDrawScore;
    }
}