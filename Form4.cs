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
    public partial class Form4 : Form
    {
        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form3 f3 = new Form3();


            f3.Show();
            f4.Hide();
        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form4 f4 = new Form4();


            f1.Show();
            f4.Hide();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kargo.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form4()
        {
            InitializeComponent();
        }
        public void listele1()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from musteriler", baglanti);
            adtr.Fill(ds, "musteriler");
            dataGridView1.DataSource = ds.Tables["musteriler"];
            adtr.Dispose();
            baglanti.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listele1();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            komut.Connection = baglanti;
            komut.CommandText = "update musteriler set tc_no='" + textBox1.Text + "', ad='" + textBox2.Text + "', soyad='" + textBox3.Text + "', mail ='" + textBox4.Text + "', adres ='" + textBox5.Text+  "', dtarihi ='" + dateTimePicker1.Text + "', telno ='" + textBox7.Text + "' where tc_no=" + textBox1.Text + "";
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            MessageBox.Show("Kayıt Güncellendi!");
            listele1();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir;
            satir = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text  = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

       
    }
}
