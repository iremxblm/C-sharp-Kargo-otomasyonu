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
    public partial class Form10 : Form
    {

        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=kargo.accdb");
        DataTable tablo = new DataTable();
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
     
        private void Form10_Load(object sender, EventArgs e)
        {
            bag.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From teslimat", bag);
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
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From teslimat", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label14.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update teslimat set kargo_durumu='" + textBox1.Text + "'  where takip_no='" + textBox2.Text+ "' ";
            komut.ExecuteNonQuery();
            bag.Close();
            ds.Clear();
            listele();
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true )

            {
                komut = new OleDbCommand();
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "update teslimat set  teslim_tarih='" + dateTimePicker1.Text + "'  where takip_no='" + textBox2.Text + "' ";
                komut.ExecuteNonQuery();
                bag.Close();
                ds.Clear();
                listele();
                label17.Visible = true;
                dateTimePicker1.Visible = true;

            }
            else
            {
                label17.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
