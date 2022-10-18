using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace gameparkerjames
{
    class Player
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image player;//variable for the player's image
        public Rectangle playerRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 10;
            y = 360;
            width = 60;
            height = 80;
            player = Properties.Resources.surviver1;
            playerRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawPlayer(Graphics g)
        {

            g.DrawImage(player, playerRec);
        }
        public void MovePlayer(string move)
        {
            playerRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (playerRec.Location.X > 500) // is player within 10 of right side
                {

                    x = 490;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    playerRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (playerRec.Location.X < 10) // is player within 10 of left side
                {

                    x = 20;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    playerRec.Location = new Point(x, y);
                }

            }
            if (move == "up")
            {
                if (playerRec.Location.Y < 10) // is player within 10 of top side
                {

                    y = 20;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 5;
                    playerRec.Location = new Point(x, y);
                }

            }
            if (move == "down")
            {
                if (playerRec.Location.Y > 400) // is player within 100 of bottem side
                {

                    y = 380;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    y += 5;
                    playerRec.Location = new Point(x, y);
                }

            }

        }

    }
}
