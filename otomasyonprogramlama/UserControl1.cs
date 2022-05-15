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
using System.Drawing.Printing;

namespace otomasyonprogramlama
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;
        }
        OleDbConnection eklebaglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\pc\\Desktop\\otomasyonprogramlama.accdb");
        OleDbCommand eklekomut = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        void Listele()
        {
            eklebaglanti.Open();
            da = new OleDbDataAdapter("select * from kitaplar", eklebaglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            eklebaglanti.Close();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(tKno.Text == "Kitap No")
            {
                tKno.Text = "";
                tKno.ForeColor = Color.Black;
            }
        }

        private void tKno_Leave(object sender, EventArgs e)
        {
            if (tKno.Text == "")
            {
                tKno.Text = "Kitap No";
                tKno.ForeColor = Color.Silver;
            }
        }

        private void tKadı_Enter(object sender, EventArgs e)
        {
            if (tKadı.Text == "Kitap Adı")
            {
                tKadı.Text = "";
                tKadı.ForeColor = Color.Black;
            }
        }

        private void tKadı_Leave(object sender, EventArgs e)
        {
            if (tKadı.Text == "")
            {
                tKadı.Text = "Kitap Adı";
                tKadı.ForeColor = Color.Silver;
            }
        }

        private void tKyazarı_Enter(object sender, EventArgs e)
        {
            if (tKyazarı.Text == "Kitap Yazarı")
            {
                tKyazarı.Text = "";
                tKyazarı.ForeColor = Color.Black;
            }
        }

        private void tKbaskıyılı_Enter(object sender, EventArgs e)
        {
            if (tKbaskıyılı.Text == "Kitap Baskı Yılı")
            {
                tKbaskıyılı.Text = "";
                tKbaskıyılı.ForeColor = Color.Black;
            }
        }

        private void tKyazarı_Leave(object sender, EventArgs e)
        {
            if (tKyazarı.Text == "")
            {
                tKyazarı.Text = "Kitap Yazarı";
                tKyazarı.ForeColor = Color.Silver;
            }
        }

        private void tKbaskıyılı_Leave(object sender, EventArgs e)
        {
            if (tKbaskıyılı.Text == "")
            {
                tKbaskıyılı.Text = "Kitap Baskı Yılı";
                tKbaskıyılı.ForeColor = Color.Silver;
            }
        }

        private void tKsayısı_Enter(object sender, EventArgs e)
        {
            if (tKsayısı.Text == "Kitap Sayfa Sayısı")
            {
                tKsayısı.Text = "";
                tKsayısı.ForeColor = Color.Black;
            }
        }

        private void tKsayısı_Leave(object sender, EventArgs e)
        {
            if (tKsayısı.Text == "")
            {
                tKsayısı.Text = "Kitap Sayfa Sayısı";
                tKsayısı.ForeColor = Color.Silver;
            }
        }

        private void tKdili_Enter(object sender, EventArgs e)
        {
            if (tKdili.Text == "Kitap Dili")
            {
                tKdili.Text = "";
                tKdili.ForeColor = Color.Black;
            }
        }

        private void tKdili_Leave(object sender, EventArgs e)
        {
            if (tKdili.Text == "")
            {
                tKdili.Text = "Kitap Dili";
                tKdili.ForeColor = Color.Silver;
            }
        }

        private void tKyayınevi_Enter(object sender, EventArgs e)
        {
            if (tKyayınevi.Text == "Kitap Yayın Evi")
            {
                tKyayınevi.Text = "";
                tKyayınevi.ForeColor = Color.Black;
            }
        }

        private void tKyayınevi_Leave(object sender, EventArgs e)
        {
            if (tKyayınevi.Text == "")
            {
                tKyayınevi.Text = "Kitap Yayın Evi";
                tKyayınevi.ForeColor = Color.Silver;
            }
        }

        private void rTacıklama_Enter(object sender, EventArgs e)
        {
            if (rTacıklama.Text == "Kitap Açıklama")
            {
                rTacıklama.Text = "";
                rTacıklama.ForeColor = Color.Black;
            }
        }

        private void rTacıklama_Leave(object sender, EventArgs e)
        {
            if (rTacıklama.Text == "")
            {
                rTacıklama.Text = "Kitap Açıklama";
                rTacıklama.ForeColor = Color.Silver;
            }
        }
        int sayac =0;

        private void button1_Click(object sender, EventArgs e)
        { 
            eklebaglanti.Open();
            eklekomut.Connection = eklebaglanti;

            eklekomut.CommandText = "insert into kitaplar(KitapNo , KitapAdı , YazarAdı , BaskıYılı , SayfaSayısı , Dili , YayınEvi , Acıklama)" +
                "values(@pKitapNo , @pKitapAdı , @pYazarAdı , @pBaskıYılı , @pSayfaSayısı , @pDili , @pYayınEvi , @pAcıklama ) ";
            eklekomut.Parameters.AddWithValue("@pKitapNo",tKno.Text);
            eklekomut.Parameters.AddWithValue("@pKitapAdı", tKadı.Text);
            eklekomut.Parameters.AddWithValue("@pYazarAdı", tKyazarı.Text);
            eklekomut.Parameters.AddWithValue("@pBaskıYılı", tKbaskıyılı.Text);
            eklekomut.Parameters.AddWithValue("@pSayfaSayısı", tKsayısı.Text);
            eklekomut.Parameters.AddWithValue("@pDili", tKdili.Text);
            eklekomut.Parameters.AddWithValue("@pYayınEvi", tKyayınevi.Text);
            eklekomut.Parameters.AddWithValue("@pAcıklama", rTacıklama.Text);

            eklekomut.ExecuteNonQuery();

            eklebaglanti.Close();

            if(sayac ==0)
            {
                tKno.Text = "Kitap No"; tKno.ForeColor = Color.Silver;
                tKadı.Text = "Kitap Adı"; tKadı.ForeColor = Color.Silver;
                tKyazarı.Text = "Kitap Yazarı"; tKyazarı.ForeColor = Color.Silver;
                tKbaskıyılı.Text = "Kitap Baskı Yılı"; tKbaskıyılı.ForeColor = Color.Silver;
                tKsayısı.Text = "Kitap Sayfa Sayısı"; tKsayısı.ForeColor = Color.Silver;
                tKdili.Text = "Kitap Dili"; tKdili.ForeColor = Color.Silver;
                tKyayınevi.Text = "Kitap Yayın Evi"; tKyayınevi.ForeColor = Color.Silver;
                rTacıklama.Text = "Kitap Açıklama"; rTacıklama.ForeColor = Color.Silver;
            }
        }
        PrintDialog prt = new PrintDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument kagit = new PrintDocument();
            DialogResult yazdirma;
            yazdirma = prt.ShowDialog();
            kagit.PrintPage += Kagit_PrintPage;

            if(yazdirma == DialogResult.OK)
            {
                kagit.Print();
            }
        }

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {
            string neyazicam = "Kitap No:  " + tKno.Text + "   " + "Kitap Adı:  " + tKadı.Text;
            Font yaziailesi = new Font("Arial" ,12);
            SolidBrush kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString(neyazicam , yaziailesi, kalem, 10, 20);
        }
    }
}
