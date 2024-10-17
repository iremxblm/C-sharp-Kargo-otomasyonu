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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=kargo.accdb");

        DataTable tablo = new DataTable();

        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void Form11_Load(object sender, EventArgs e)
        {
            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kargolar", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            listele();

        }
        void listele()

        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kargolar", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();

            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kargolar Where gonder_tarih='" + dateTimePicker1.Text + "'", bag);

            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;

            adtr.Dispose();

            bag.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void textBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

            Form5 f5 = new Form5();
            f5.Show();
        }

        private void kARGOFİYATIHESAPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void kARGOTAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void tAHMİNİTESLİMATSÜRELERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void eNYAKINŞUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();

            f9.Show();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
