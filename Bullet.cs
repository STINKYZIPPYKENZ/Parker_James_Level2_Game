﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace gameparkerjames
{
    class Bullet
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image bulletImage;//variable for the bullets's image

        public Rectangle bulletRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Bullet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 30;
            height = 25;
            //bulletImage contains the bullet1.png image
            bulletImage = Properties.Resources.bullet1;
            bulletRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Bullet class
        public void DrawBullet(Graphics g)
        {
            bulletRec = new Rectangle(x, y, width, height);
            g.DrawImage(bulletImage, bulletRec);
        }
        public void MoveBullet()
        {
            y += 5;

            bulletRec.Location = new Point(x, y);
        }

    }
}