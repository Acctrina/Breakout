namespace Breakout
    {
    partial class Breakout
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
            txtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            gameTImer = new System.Windows.Forms.Timer(components);
            difficultyLabel = new Label();
            gameEnd = new Label();
            timerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(15, 15);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(88, 24);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            // 
            // player
            // 
            player.BackColor = Color.White;
            player.Location = new Point(405, 587);
            player.Margin = new Padding(4, 3, 4, 3);
            player.Name = "player";
            player.Size = new Size(173, 18);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Cornsilk;
            ball.Location = new Point(483, 498);
            ball.Margin = new Padding(4, 3, 4, 3);
            ball.Name = "ball";
            ball.Size = new Size(13, 12);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // gameTImer
            // 
            gameTImer.Interval = 20;
            gameTImer.Tick += mainGameTimerEvent;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            difficultyLabel.ForeColor = Color.White;
            difficultyLabel.Location = new Point(740, 15);
            difficultyLabel.Margin = new Padding(4, 0, 4, 0);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(93, 24);
            difficultyLabel.TabIndex = 2;
            difficultyLabel.Text = "Difficulty:";
            // 
            // gameEnd
            // 
            gameEnd.AutoSize = true;
            gameEnd.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameEnd.ForeColor = Color.White;
            gameEnd.Location = new Point(340, 346);
            gameEnd.Margin = new Padding(4, 0, 4, 0);
            gameEnd.Name = "gameEnd";
            gameEnd.Size = new Size(0, 24);
            gameEnd.TabIndex = 3;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = Color.White;
            timerLabel.Location = new Point(360, 15);
            timerLabel.Margin = new Padding(4, 0, 4, 0);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(21, 24);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "0";
            // 
            // Breakout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(924, 628);
            Controls.Add(timerLabel);
            Controls.Add(gameEnd);
            Controls.Add(difficultyLabel);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtScore);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Breakout";
            Text = "Breakout";
            KeyDown += keyispressed;
            KeyUp += keyisnotpressed;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTImer;
        private Label difficultyLabel;
        private Label gameEnd;
        private Label timerLabel;
    }
}
