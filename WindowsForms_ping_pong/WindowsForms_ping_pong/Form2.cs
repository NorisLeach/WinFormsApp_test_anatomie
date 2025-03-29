using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_ping_pong
{
    public partial class Form2_Mouse : Form
    {
        public int verticala = 12;
        public int orizontala = 12;
        public int punctaj = 0;
        public Form2_Mouse()
        {
            InitializeComponent(); InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds; // setare full screen
            label1_punctaj.Text += punctaj.ToString(); // punctaj initializat cu 0
            label1_punctaj.ForeColor = Color.DeepPink; //pozitia rachetei: jos, in centru

            pictureBox_Ronaldo.Top = panel1_playground.Bottom - 100;
            pictureBox_Ronaldo.Left = (Screen.PrimaryScreen.Bounds.Right - pictureBox_Ronaldo.Width) / 2;
            timer1.Enabled = true;
        }

        private void Form2_Mouse_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // racheta se va misca impreuna cu mouse-ul, pe orizontala;
            pictureBox_Ronaldo.Left = Cursor.Position.X - (pictureBox_Ronaldo.Width / 2);
            pictureBox_Ballon.Left += orizontala;
            pictureBox_Ballon.Top += verticala;

            if (pictureBox_Ballon.Bottom >= pictureBox_Ronaldo.Top && pictureBox_Ballon.Bottom <= pictureBox_Ronaldo.Bottom && pictureBox_Ballon.Left >= pictureBox_Ronaldo.Left && pictureBox_Ballon.Right <= pictureBox_Ronaldo.Right)

            {
                verticala += 5;
                orizontala += 5;
                verticala = -verticala;

                punctaj += 1;
                label1_punctaj.Text = "Punctaj: " + punctaj.ToString();

            }
            if (pictureBox_Ballon.Left <= panel1_playground.Left)
            {
                orizontala = -orizontala;
            }

            if (pictureBox_Ballon.Right >= panel1_playground.Right)
            {
                orizontala = -orizontala;
            }

            if (pictureBox_Ballon.Top <= panel1_playground.Top)
            {
                verticala = -verticala;
            }

            if (pictureBox_Ballon.Bottom >= panel1_playground.Bottom)
            {
                timer1.Enabled = false;
                MessageBox.Show("S - a terminat jocul");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
