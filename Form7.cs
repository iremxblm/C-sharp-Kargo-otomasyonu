using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1;
            double agırlık;
            int sayi1;
            agırlık = 0.1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            d1 = sayi1 * agırlık;
          
                double desi;
                int en, boy, yukseklık;
                en = Convert.ToInt32(textBox2.Text);
                boy = Convert.ToInt32(textBox3.Text);
                yukseklık = Convert.ToInt32(textBox4.Text);
                desi = (en * boy * yukseklık) / 500;
               label9.Text = Convert.ToString(desi);
                double toplam = (d1 + desi);
                textBox6.Text = Convert.ToString(toplam);
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked==true)
                {
                int standart = 10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (standart + sayi2);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox1.Checked == false )
            {
                int standart = 10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2-standart );
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                int alıcı = 10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (alıcı + sayi2);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox2.Checked == false)
            {
                int alıcı = 10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 - alıcı);
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                int il = 5;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 - il);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox3.Checked == false)
            {
                int il = 5;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 +il);
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                int adres = 15;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (adres + sayi2);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox4.Checked == false)
            {
                int adres = 15;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 - adres);
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                int kargo = 5;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 - kargo);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox5.Checked == false)
            {
                int kargo = 5;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 + kargo);
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form7 f7 = new Form7();
            f1.Show();
        }

        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form7 f7 = new Form7();
            f3.Show();
        }

        private void kARGOGÖNDERMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form7 f7 = new Form7();
            f5.Show();
        }

        private void tAHMİNİTESLİMATSÜRELERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            Form7 f7 = new Form7();
            f6.Show();
        }

        private void eNYAKINŞUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();

            f9.Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                int ogr =10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 - ogr);
                textBox6.Text = Convert.ToString(s1);

            }
            else if (checkBox6.Checked == false)
            {
                int ogr = 10;
                int sayi2;
                sayi2 = Convert.ToInt32(textBox6.Text);
                int s1 = (sayi2 +ogr);
                textBox6.Text = Convert.ToString(s1);
            }
        }

        private void kARGOTAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void aDMİNPANELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void rAPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
