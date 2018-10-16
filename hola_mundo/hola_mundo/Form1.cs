using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola_mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad=Convert.ToInt32(textBox1.Text);
            if (edad >= 18)
            {
                MessageBox.Show("Mayor de 18 años");
            }
            else
            {
                MessageBox.Show("Menor de 18");
            }
        
        
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1, x2, rest;
            x1 = Convert.ToInt32(textBox2.Text);
            x2 = Convert.ToInt32(textBox3.Text);
            rest = x1 + x2;
            textBox4.Text = rest.ToString();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x1;
            double rest = 1;
            x1 = Convert.ToInt32(textBox2.Text);
            for (int n = 1; n <= x1; n++)
            {
                rest = rest * n;
            }
            textBox4.Text = rest.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x1, x2, rest = 0;
            x1 = Convert.ToInt32(textBox2.Text);
            x2 = Convert.ToInt32(textBox3.Text);
            for (int n = 1; n <= x2; n++)
            {
                rest = rest+x1;
            }
            textBox4.Text = rest.ToString();
            
        }
    }
}
