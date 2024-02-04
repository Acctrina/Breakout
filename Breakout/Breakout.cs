using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Media;
using System.Configuration;


namespace Breakout
{
    public partial class Breakout : Form
    {

        bool moveLeft;
        bool moveRight;
        bool isGameOver;

        int tiles;
        int score;
        int ballx;
        int bally;
        int playerSpeed;
        double value;

        private SoundPlayer breakingSFX;
        private SoundPlayer bounceSFX;
        private SoundPlayer winSFX;
        private SoundPlayer loseSFX;

        PictureBox[] blockArray;

        public Breakout(string difficulty)
        {
            InitializeComponent();
            breakingSFX = new SoundPlayer(@"C:\Users\User\Downloads\breakingSFX.wav");
            bounceSFX = new SoundPlayer(@"C:\Users\User\Downloads\bounceSFX.wav");
            winSFX = new SoundPlayer(@"C:\Users\User\Downloads\winSFX.wav");
            loseSFX = new SoundPlayer(@"C:\Users\User\Downloads\loseSFX.wav");

            //Number of tiles generated for each difficulty
            difficultyLabel.Text = "Difficulty: " + difficulty;
            if (difficulty == "Easy")
            {
                tiles = 30;
                LoadBlocks();

            }
            else if (difficulty == "Medium")
            {
                tiles = 60;
                LoadBlocks();

            }
            else if (difficulty == "Hard")
            {
                tiles = 100;
                LoadBlocks();

            }

        }

        private void setupGame()
        {

            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 10;
            txtScore.Text = "Score: " + score;

            ball.Left = 350;
            ball.Top = 350;
            player.Left = 350;

            gameTImer.Start();
        }


        private void gameOver(string message)
        {
            isGameOver = true;
            gameTImer.Stop();

            txtScore.Text = "Score: " + score;
            gameEnd.Text = message;
        }

        //Generates tile layout based on array
        private void LoadBlocks()
        {

            blockArray = new PictureBox[tiles];

            int a = 0;

            int top = 50;
            int left = 100;

            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 12;
                blockArray[i].Width = 50;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;


                if (a == 10)
                {
                    top = top + 25;
                    left = 100;
                    a = 0;
                }

                if (a < 10)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 75;
                }

            }
            setupGame();
        }

        private void removeBlocks()
        {
            foreach (PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            //Timer
            timerLabel.Text = "Timer: " + (value += 0.03).ToString("0.00") + " Seconds"; 

            //Left Boundry limit for Player
            if (moveLeft == true && player.Left > 0) 
            {
                player.Left -= playerSpeed;
            }
            //Right Boundry limit for player
            if (moveRight == true && player.Left < 750) 
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            //Boundry limits for ball
            if (ball.Left < 0 || ball.Left > 900) 
            {
                ballx = -ballx;
                bounceSFX.Play();
            }
            if (ball.Top < 0)
            {
                bally = -bally;
                bounceSFX.Play();
            }

            //Ball Speed for Respective Difficulties
            if (ball.Bounds.IntersectsWith(player.Bounds)) 
            {

                ball.Top = 405;
                bounceSFX.Play();

                if (difficultyLabel.Text == "Difficulty: Easy")
                {
                    bally = -5;
                }
                if (difficultyLabel.Text == "Difficulty: Medium")
                {
                    bally = -9;
                }
                if (difficultyLabel.Text == "Difficulty: Hard")
                {
                    bally = -13;
                }

            }

            //Removes tiles which ball contacts
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                        breakingSFX.Play();
                    }
                }

            }

            if (score == tiles)
            {
                gameOver("You Win!\nPress Enter to Play Again.\nPress Esc to return to Main Menu.");
                winSFX.Play();
            }

            if (ball.Top > 610)
            {
                gameOver("Game Over!\nPress Enter to Try Again.\nPress Esc to return to Main Menu.");
                loseSFX.Play();
            }

        }

        private void keyispressed(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Main_Menu menu = new Main_Menu();
                menu.Show();
                this.Hide();
            }

        }

        private void keyisnotpressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                LoadBlocks();
                gameEnd.Text = "";
                value = 0;
            }
        }
    }
}