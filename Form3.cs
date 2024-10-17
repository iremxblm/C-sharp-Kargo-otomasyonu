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
    public partial class Form3 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kargo.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form3()
        {
            InitializeComponent();
        }


        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from musteriler", baglanti);
            adtr.Fill(ds, "musteriler");
            dataGridView1.DataSource = ds.Tables["musteriler"];
            adtr.Dispose();
            baglanti.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            komut.Connection = baglanti;
            komut.CommandText = "Insert Into musteriler (tc_no,ad,soyad,mail,adres,dtarihi,telno) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + textBox7.Text + "')";
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı!");
            ds.Clear();
            listele();


        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void gÜNCELLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void kARGOGÖNDERMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form3 f3 = new Form3();


            f5.Show();
            f3.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update musteriler set ad='" + textBox2.Text + "', soyad='" + textBox3.Text + "', mail='" + textBox4.Text + "', adres='" + textBox5.Text + "', dtarihi='" + dateTimePicker1.Text + "', telno='" + textBox7.Text +  "'  where tc_no='"  + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();

        }
        private void dataGridView1_CellEnterClick(object sender, DataGridViewCellEventArgs e)

        {
          
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form5 f5 = new Form5();

            f1.Show();
        }

        private void tAHMİNİNTESLİMATSÜRELERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            Form3 f3 = new Form3();

            f6.Show();
        }

        private void aDMİNPANELİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void gÖNDERİTAKİPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            Form3 f3 = new Form3();

            f7.Show();
        }

        private void eNYAKINŞUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
   
            f9.Show();
        }

        private void rAPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void kARGOTAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
