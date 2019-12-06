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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\emlakkayit.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();




        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mus = new müsteri();
            mus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ev = new ev();
            ev.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from musteri  " , baglanti );
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;

            OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from ev  ", baglanti);
            adap2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;

            baglanti.Close();
        }
    }
}
