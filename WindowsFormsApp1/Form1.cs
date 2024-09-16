using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gsgol, fbgol, bjkgol, tsgol;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gsgol = rastgele.Next(0, 6);
            fbgol = rastgele.Next(0, 6);
            bjkgol = rastgele.Next(0, 6);
            tsgol = rastgele.Next(0, 6);
            label5.Text = gsgol.ToString();
            label7.Text = fbgol.ToString();
            label6.Text = bjkgol.ToString();
            label8.Text = tsgol.ToString();

            if (gsgol)



            





        }
    }
}
