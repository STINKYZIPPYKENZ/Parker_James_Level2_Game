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
                    // declare space for an array of 10 objects called bullet 
        Bullet[] bullet = new Bullet[10];
      

        public Survival()
        {
            InitializeComponent();            
            for (int i = 0; i < 10; i++)
            {
                int x = 10 + (i * 55);
                bullet[i] = new Bullet(x);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Bullet class's DrawBullet method to draw the image bullet1 
            for (int i = 0; i < 10; i++)
            {
                //call the Bullet class's drawBullet method to draw the images
                bullet[i].DrawBullet(g);
            }


        }

        private void TmrBullet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                bullet[i].MoveBullet();

                //if a bullet reaches the bottom of the Game Area reposition it at a random postion on the top, side or bottom
                if (bullet[i].y >= PnlGame.Height)
                {
                    bullet[i].y = 30;
                   
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
