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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(kAdı.Text == "Kullanıcı Adı")
            {
                kAdı.Text = "";

                kAdı.ForeColor = Color.Black;

            }
        }

        private void kAdı_Leave(object sender, EventArgs e)
        {
            if(kAdı.Text == "")
            {
                kAdı.Text = "Kullanıcı Adı";

                kAdı.ForeColor = Color.Silver;
            }
        }

        private void kŞifre_Enter(object sender, EventArgs e)
        {
            if (kŞifre.Text == "Şifre")
            {
                kŞifre.Text = "";

                kŞifre.ForeColor = Color.Black;

                kŞifre.PasswordChar = '*';

            }
        }

        private void kŞifre_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void kŞifre_Leave(object sender, EventArgs e)
        {
            if (kŞifre.Text == "")
            {
                kŞifre.Text = "Şifre";

                kŞifre.ForeColor = Color.Silver;
            }
        }
    }
}
