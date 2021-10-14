using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitCatcher
{
    public partial class Form1 : Form
    {
        bool isGameOver;
        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                basket.Left += -30;
            }
            if(e.KeyCode == Keys.Right)
            {
                basket.Left += 30;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }



        Random r = new Random();
        int pts = 0;
        void falldown(PictureBox apple, int speed)
        {
            if (apple.Top <= this.Height)  // for the first 3 apples
            {
                apple.Top += speed; // apples fall down (direction of fall)
            }

            else if (apple.Top > this.Height) //for the rest of the apples
            {
                apple.Location = new Point((r.Next(100, 700)), 0); //spawn them in a random position
            }

            //score
            if (apple.Bounds.IntersectsWith(basket.Bounds))
            {
                apple.Location = new Point((r.Next(100, 700)), 0);
                pts++;
                score.Text = "Score: " + pts.ToString();
            }


            if (pts == 3)
            {
                gameOver("You win!");
            }



        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //apples fall down with the speed 1, 2, 3
            falldown(apple1, 1);
            falldown(apple2, 2);
            falldown(apple3, 3);


        }

        // 
        private void gameOver(string message)
        {
            isGameOver = true;

            timer1.Stop();

            score.Text = "Score: " + pts.ToString() + Environment.NewLine + message;
        }


        private void resetGame()
        {
            score.Text = "Score: 0";
            pts = 0;

            basket.Left = 348;
            basket.Top = 484;

            isGameOver = false;

            apple1.Left = 126;
            apple1.Top = 179;

            apple2.Left = 348;
            apple2.Top = 31;

            apple3.Left = 645;
            apple3.Top = 111;

            timer1.Start();  //start the game
        }


    }
}
