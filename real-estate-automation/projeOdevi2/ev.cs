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
    public partial class ev : Form
    {
        public ev()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\emlakkayit.accdb");

        private void ev_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into ev (adres,katsayi,odasayi,metrekare,binayas,fiyat) values ('" + textBox7.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ev bilgileri Eklendi !");
            baglanti.Close();

            textBox7.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from ev where adres='" + textBox7.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ev Bilgileri Silindi");
            baglanti.Close();
            textBox7.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update ev set adres='" + textBox7.Text + "',katsayi='" + textBox2.Text + "' ,odasayi='" + textBox3.Text + "' ,metrekare='" + textBox4.Text + "' ,binayas='" + textBox5.Text + "' ,  fiyat='" + textBox6.Text + "' where adres='" + textBox7.Text + "'  ", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ev Bilgisi Değiştirildi");
            baglanti.Close();
            textBox7.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from ev where adres= '" + textBox7.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text = oku["katsayi"].ToString();
                textBox3.Text = oku["odasayi"].ToString();
                textBox4.Text = oku["metrekare"].ToString();
                textBox5.Text = oku["binayas"].ToString();
                textBox6.Text = oku["fiyat"].ToString();
            }
            baglanti.Close();
        }
    }
}
