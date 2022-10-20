using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gameparkerjames
{
    public partial class Survival : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called bullet 
        Bullet[] bullet = new Bullet[7];
        Random yspeed = new Random();
        Player player = new Player();
        bool left, right, up, down;
        string move;
        int score, lives;

        public Survival()
        {
            InitializeComponent();            
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 70);
                bullet[i] = new Bullet(x);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Bullet class's DrawBullet method to draw the image bullet1 
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 8 to 16 and put it in rndmspeed
                int rndmspeed = yspeed.Next(8, 16);
                bullet[i].x += rndmspeed;
                //call the Bullet class's drawBullet method to draw the images
                bullet[i].DrawBullet(g);
                player.DrawPlayer(g);
            }


        }

        private void TmrBullet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                bullet[i].MoveBullet();

                //if a bullet reaches the right side of the Game Area it is repositiond at the left side.
                if (bullet[i].x >= PnlGame.Height)
                {
                    score += 1;//update the score
                    LblScore.Text = score.ToString();// display score
                    bullet[i].x = -300;
                    int rndmspeed = yspeed.Next(8, 18);
                    bullet[i].x += rndmspeed;
                }
                if (player.playerRec.IntersectsWith(bullet[i].bulletRec))
                {
                    //reset bullet[i] back to side of panel
                    bullet[i].x = -600; // set  x value of bulletRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                    int rndmspeed = yspeed.Next(8, 17);
                    bullet[i].x += rndmspeed;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void Survival_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left, right, up and down arrow keys to move the player. \n Don't get hit by the bullets! \n Every bullet that gets past scores a point. \n If a bullet hits a player a life is lost! \n \n Enter your Name \n Click Start to begin", "Game Instructions");
            TxtName.Focus();

        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);

            TmrBullet.Enabled = true;
            TmrPlayer.Enabled = true;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrBullet.Enabled = false;
            TmrPlayer.Enabled = false;
        }

        private void LblScore_Click(object sender, EventArgs e)
        {

        }

        private void Survival_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void Survival_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void TmrPlayer_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.MovePlayer(move);
            }
            if (up) // if up arrow key pressed
            {
                move = "up";
                player.MovePlayer(move);
            }
            if (down) // if down arrow key pressed
            {
                move = "down";
                player.MovePlayer(move);
            }

        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrBullet.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }

}
