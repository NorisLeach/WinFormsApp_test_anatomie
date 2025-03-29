using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorisGame
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10, force = 8, score = 0, playerSpeed = 10, backgroundSpeed = 8;

        private void player_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Iata care sunt comenzile jocului: " + Environment.NewLine + "SPACE = saritura" + Environment.NewLine + "SAGEATA STANGA = mers in stanga" + Environment.NewLine + "SAGEATA DREAPTA = mers in dreapta");
        }


        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            player.Top = player.Top + jumpSpeed;

            if (goLeft == true && player.Left > 60)
                player.Left = player.Left - playerSpeed;  
            if (goRight == true && player.Right < (this.ClientSize.Width-60))
                player.Left = player.Left + playerSpeed;

            if (goLeft == true && background.Left < 0)
            {
                background.Left = background.Left + backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goRight == true && background.Left > -1148)
            {
                background.Left = background.Left - backgroundSpeed;
                MoveGameElements("back");
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force = force - 1;
            }
            else
                jumpSpeed = 12;

            if (jumping == true && force < 0)
                jumping = false;

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "platform")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if(x is PictureBox && (string)x.Tag == "coin")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score = score + 1;
                    }
                }
            }

            if(player.Bounds.IntersectsWith(key.Bounds))
            {
                key.Visible = false;
                hasKey = true;
            }

            if(player.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
            {
                door.Image = Properties.Resources.door_open;
                GameTimer.Stop();
                MessageBox.Show("Felicitari ! Ai terminat jocul !" + Environment.NewLine + "Apasa pe OK ca sa incepi din nou jocul !");
                RestartGame();
            }

            if(player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                MessageBox.Show("Ai pierdut aiae !" + Environment.NewLine + "Apasa pe OK ca sa incepi din nou jocul !");
                RestartGame();
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (jumping == true)
                jumping = false;
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {

        }

        private void RestartGame()
        {
            Form1 window = new Form1();
            window.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "door" || x is PictureBox && (string)x.Tag == "key")
                {
                    if (direction == "back")
                        x.Left = x.Left - backgroundSpeed;
                    if (direction == "forward")
                        x.Left = x.Left + backgroundSpeed;
                }
            }
        }
    }
}
