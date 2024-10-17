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
    public partial class Form5 : Form
    {

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        public Form5()
        {
            InitializeComponent();
        }
        void listele()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kargo.accdb");
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from kargolar", con);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            adtr.Fill(ds, "kargolar");
            dataGridView1.DataSource = ds.Tables["kargolar"];
            adtr.Dispose();
            con.Close();



        }
        private void Form5_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kargo.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM musteriler";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ad"]);
                comboBox2.Items.Add(dr["soyad"]);
                comboBox3.Items.Add(dr["adres"]);
                comboBox4.Items.Add(dr["telno"]);

               
            }

            comboBox5.Items.Add("Adrese Teslim");
            comboBox5.Items.Add("Şubeye Teslim");

            comboBox6.Items.Add("Gönderici Tarafından");
            comboBox6.Items.Add("Alıcı Tarafından");

            con.Close();
            listele();
        }

        private void gİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form5 f5 = new Form5();


            f1.Show();
            f5.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int takipno = rdm.Next(100001, 999999);
   
            string baglantiyolu = "provider=microsoft.ace.oledb.12.0;data source=kargo.accdb";
            OleDbConnection baglanti = new OleDbConnection(baglantiyolu);
            baglanti.Open();
            string eklemekomutu = "insert into kargolar (gonderen_ad,gonderen_soyad,gonderen_adres,teslim_tipi,odeme_tipi,alici_adi,alici_soyad,alici_adres,alici_tel_no,takip_no,ücret,gonder_tarih) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text+ "','" + textBox10.Text + "','" + textBox11.Text + "','" + takipno.ToString() + "','" + textBox12.Text+ "','" + dateTimePicker1.Text + "')";
            OleDbCommand komut = new OleDbCommand(eklemekomutu, baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            MessageBox.Show("Gönderiniz Kaydedildi ");
            label14.Text = " Takip No: " + takipno.ToString();
            ds.Clear();
            listele();

            string baglantiyolu2 = "provider=microsoft.ace.oledb.12.0;data source=kargo.accdb";
            OleDbConnection baglanti2 = new OleDbConnection(baglantiyolu2);
            baglanti2.Open();
            string eklemekomutu2 = "insert into teslimat (takip_no,gonderen_ad,gonderen_soyad,gonderen_adres,alıcı_ad,alıcı_soyad,alıcı_adres,alıcı_tel) values ('" + takipno.ToString() + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
            OleDbCommand komut2 = new OleDbCommand(eklemekomutu2, baglanti2);
            komut2.ExecuteNonQuery();
            komut2.Dispose();
            baglanti2.Close();
            ds.Clear();
            listele();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox5.Text;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox5.Text;

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = comboBox6.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox2.Text = comboBox2.Text;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox3.Text = comboBox3.Text;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox4.Text = comboBox4.Text;
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellEnterClick(object sender, DataGridViewCellEventArgs e)

        {
            int satir;
            satir = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString();
            textBox10.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            label14.Text = dataGridView1.Rows[satir].Cells[7].Value.ToString();
            textBox12.Text = dataGridView1.Rows[satir].Cells[8].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[satir].Cells[9].Value.ToString();
           


        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form5 f5 = new Form5();

            f3.Show();



        }

        private void kAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form5 f5 = new Form5();

            f3.Show();
        }

        private void tAHMİNİTESLİMATSÜRELERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            Form5 f5 = new Form5();

            f6.Show();
        }

        private void kARGOFİYATIHESAPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            Form5 f5 = new Form5();

            f7.Show();
        }

        private void eNYAKINŞUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
     
            f9.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
