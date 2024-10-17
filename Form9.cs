using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

using System.Windows.Forms;

namespace kargo
{
    public partial class Form9 : Form
    {

        public Form9()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=kargo.accdb");

        DataTable tablo = new DataTable();

        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From sube", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            dataGridView1.Columns[0].HeaderText = "il";
            dataGridView1.Columns[1].HeaderText = "ilce";
            dataGridView1.Columns[2].HeaderText = "subeadres";
            dataGridView1.Columns[3].HeaderText = "subetelno";
            listele();
        }
        void listele()

        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From sube", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();

            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From sube Where il='" + textBox1.Text + "'", bag);

            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;

            adtr.Dispose();

            bag.Close();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();
        }

        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void kARGOGÖNDERMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kARGOGÖNDERMEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
         
        }

        private void kARGOFİYATIHESAPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void gÖNDERİTAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void tAHMİNİTESLİMATSÜRESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listele();
        }

        private void dESTEKHATTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void aDMİNPANELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
