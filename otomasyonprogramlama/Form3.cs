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
namespace otomasyonprogramlama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\Desktop\\otomasyonprogramlama.accdb");
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into giriş(kullanıcıadı , sifre) values (@pkadi , @psifre)";
            komut.Parameters.AddWithValue("@pkadi", textBox1.Text);
            komut.Parameters.AddWithValue("@psifre", textBox2.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            if (textBox1.Text == "enesselber" && textBox2.Text == "deneme")
            {
                for (progressBar1.Value = 0; progressBar1.Value < 100; progressBar1.Value++)
                    if (progressBar1.Value == 99)
                    {
                        Form2 frm2 = new Form2();
                        frm2.ShowDialog();
                    }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Kullanıcı Adı")
            {           
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
            }
        }
    }
}
