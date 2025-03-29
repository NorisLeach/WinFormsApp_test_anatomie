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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_mouse_Click(object sender, EventArgs e)
        {
            Form2_Mouse varForm2_Mouse = new Form2_Mouse();
            varForm2_Mouse.Show();
        }
        private void button1_tastatura_Click(object sender, EventArgs e)
        {
            Form2_Tastatura varForm2_Tastatura = new Form2_Tastatura();
            varForm2_Tastatura.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
