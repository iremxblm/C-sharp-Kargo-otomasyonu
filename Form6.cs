using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kargo
{
    public partial class Form6 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kargo.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM gonderizamanı";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["nereden"]);
                comboBox2.Items.Add(dr["nereye"]);
                
            }

  
            con.Close();

          



        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kargo.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM gonderizamanı";
            dr = cmd.ExecuteReader();

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                while (dr.Read())
                {
                    textBox1.Text = "1 gün";
                }

            }

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                while (dr.Read())
                {
                    textBox1.Text ="3 gün ";
                }

            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                while (dr.Read())
                {
                    textBox1.Text = "2 gün";
                }

            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                while (dr.Read())
                {
                    textBox1.Text = "3 gün";
                }

            }

            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                while (dr.Read())
                {
                    textBox1.Text = "1 gün ";
                }

            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                while (dr.Read())
                {
                    textBox1.Text = "4 gün";
                }

            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                while (dr.Read())
                {
                    textBox1.Text = "2 gün";
                }

            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                while (dr.Read())
                {
                    textBox1.Text = "3 gün";
                }

            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                while (dr.Read())
                {
                    textBox1.Text = "1 gün";
                }

            }
            con.Close();
        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form6 f6 = new Form6();

            f1.Show();
        }

        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form6 f6 = new Form6();

            f3.Show();
        }

        private void kARGOGÖNDERMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form6 f6 = new Form6();

            f5.Show();
        }

        private void tAHMİNİTESLİMATSÜRELERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
           
            f6.Show();
        }

        private void kARGOFİYATIHESAPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            Form6 f6 = new Form6();

            f7.Show();
        }

        private void eNYAKINŞUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();

            f9.Show();
        }

        private void kARGOTAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
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
