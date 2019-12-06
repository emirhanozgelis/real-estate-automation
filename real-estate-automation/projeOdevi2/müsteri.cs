using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace projeOdevi2
{
    public partial class müsteri : Form
    {
        public müsteri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\emlakkayit.accdb");

        private void müsteri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into musteri (tc,adı,soyadı,dyeri,telefon,adres) values ('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi !");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from musteri where tc='"+textBox1.Text+"'" , baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Silindi");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update musteri set tc='"+textBox1.Text+"',adı='"+textBox2.Text+"' ,soyadı='"+textBox3.Text+ "' ,dyeri='" + textBox4.Text + "' ,telefon='" + textBox5.Text + "' ,  adres='" + textBox6.Text + "' where tc='"+textBox1.Text+"'  ",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Bilgisi Değiştirildi");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from musteri where tc= '" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                textBox2.Text = oku["adı"].ToString();
                textBox3.Text = oku["soyadı"].ToString();
                textBox4.Text = oku["dyeri"].ToString();
                textBox5.Text = oku["telefon"].ToString();
                textBox6.Text = oku["adres"].ToString();
            }
            baglanti.Close();

        }
    }
}
