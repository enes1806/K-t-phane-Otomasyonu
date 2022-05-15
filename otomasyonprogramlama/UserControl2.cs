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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\otomasyonprogramlama.accdb");
        DataTable dt = new DataTable();
        OleDbDataAdapter adtr;
        void listele()
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("select * from kitaplar", baglanti);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
