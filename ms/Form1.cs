using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t, y, sonuc;
            t = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            sonuc = (t * y) / 2;
            label3.Text = "Üçgenin Alanı " + sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dogumYili, yas, yil;
            yil = DateTime.Now.Year;
            dogumYili = Convert.ToInt32(textBox4.Text);
            yas = yil - dogumYili;
            label4.Text = yas.ToString() + " Yaşındasınız.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n, sonuc;
            n = Convert.ToDouble(textBox3.Text);
            sonuc = n * (n + 1) / 2;
            label7.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double yariCap, alan;
            yariCap = Convert.ToDouble(textBox5.Text);
            alan = Math.PI * yariCap * yariCap;
            label5.Text = alan.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double yariCap, cevre;
            yariCap = Convert.ToDouble(textBox5.Text);
            cevre = 2 * Math.PI * yariCap;
            label5.Text = cevre.ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5, s6, sonuc;
            s1= Convert.ToInt32(textBox6.Text);
            s2 = Convert.ToInt32(textBox7.Text);
            s3 = Convert.ToInt32(textBox9.Text);
            s4 = Convert.ToInt32(textBox8.Text);
            s5 = Convert.ToInt32(textBox11.Text);
            s6 = Convert.ToInt32(textBox10.Text);
            sonuc = s1 + s2 + s3 + s4 + s5 + s6;
            label10.Text = sonuc.ToString();
        }
    }
}
