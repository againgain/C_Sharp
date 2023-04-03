using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoguraTataki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            int i;
            i = a.Next(1, 7);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            if (i == 1) pictureBox1.Visible = true;
            if (i == 2) pictureBox2.Visible = true;
            if (i == 3) pictureBox3.Visible = true;
            if (i == 4) pictureBox4.Visible = true;
            if (i == 5) pictureBox5.Visible = true;
            if (i == 6) pictureBox6.Visible = true;


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
        }
    }
}
