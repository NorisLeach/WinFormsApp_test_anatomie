using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_test_anatomie_
{
    public partial class Form4 : Form
    {
        List<string> linii = new List<string>();
        string raspCorect;
        bool selectat;
        int i = 0;
        int nr, INDEX = 0, scor = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncarcareContinut();
            button1.Visible = false;
            button2.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(@"C:\Users\septi\Desktop\WinFormsApp_test_anatomie_\Properties\test.txt");
            string s = f.ReadLine();
            while (s != null)
            {
                linii.Add(s);
                s = f.ReadLine();
            }
        }
        private void IncarcareContinut()
        {
            richTextBox1.Text = linii[i];
            radioButton1.Text = linii[++i];
            radioButton2.Text = linii[++i];
            radioButton3.Text = linii[++i];
            radioButton4.Text = linii[++i];
            raspCorect = linii[++i];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verificare();
            if (selectat == true)
            {
                if (i + 6 <= linii.Count)
                {
                    i++;
                    IncarcareContinut();
                }
            }
        }

        private void Verificare()
        {
            selectat = false;
            nr = Convert.ToInt32(raspCorect);
            foreach (Control ctrl in panel1.Controls)
            {
                RadioButton rb = (RadioButton)ctrl;
                if (rb.Checked == true)
                {
                    selectat = true;
                    INDEX++;
                    if (rb.TabIndex == nr - 1)
                    {
                        scor = scor + 20;
                    }
                }
                if (INDEX == 5)
                {
                    MessageBox.Show("SCORUL TĂU ESTE: " + scor + " din 100 de puncte");
                    this.Close();
                    return;
                }
            }
            if (selectat == false)
            {
                MessageBox.Show("Nicio selectie facuta", "Atenție!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
    }
}
