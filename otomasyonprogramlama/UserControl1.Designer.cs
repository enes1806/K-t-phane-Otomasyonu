
namespace otomasyonprogramlama
{
    partial class UserControl1
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tKno = new System.Windows.Forms.TextBox();
            this.tKadı = new System.Windows.Forms.TextBox();
            this.tKyazarı = new System.Windows.Forms.TextBox();
            this.tKbaskıyılı = new System.Windows.Forms.TextBox();
            this.tKsayısı = new System.Windows.Forms.TextBox();
            this.tKdili = new System.Windows.Forms.TextBox();
            this.tKyayınevi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rTacıklama = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tKno
            // 
            this.tKno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKno.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKno.ForeColor = System.Drawing.Color.Silver;
            this.tKno.Location = new System.Drawing.Point(26, 14);
            this.tKno.Multiline = true;
            this.tKno.Name = "tKno";
            this.tKno.Size = new System.Drawing.Size(192, 22);
            this.tKno.TabIndex = 0;
            this.tKno.Text = "Kitap No";
            this.tKno.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tKno.Leave += new System.EventHandler(this.tKno_Leave);
            // 
            // tKadı
            // 
            this.tKadı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKadı.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKadı.ForeColor = System.Drawing.Color.Silver;
            this.tKadı.Location = new System.Drawing.Point(26, 42);
            this.tKadı.Multiline = true;
            this.tKadı.Name = "tKadı";
            this.tKadı.Size = new System.Drawing.Size(192, 22);
            this.tKadı.TabIndex = 1;
            this.tKadı.Text = "Kitap Adı";
            this.tKadı.Enter += new System.EventHandler(this.tKadı_Enter);
            this.tKadı.Leave += new System.EventHandler(this.tKadı_Leave);
            // 
            // tKyazarı
            // 
            this.tKyazarı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKyazarı.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKyazarı.ForeColor = System.Drawing.Color.Silver;
            this.tKyazarı.Location = new System.Drawing.Point(26, 70);
            this.tKyazarı.Multiline = true;
            this.tKyazarı.Name = "tKyazarı";
            this.tKyazarı.Size = new System.Drawing.Size(192, 22);
            this.tKyazarı.TabIndex = 2;
            this.tKyazarı.Text = "Kitap Yazarı";
            this.tKyazarı.Enter += new System.EventHandler(this.tKyazarı_Enter);
            this.tKyazarı.Leave += new System.EventHandler(this.tKyazarı_Leave);
            // 
            // tKbaskıyılı
            // 
            this.tKbaskıyılı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKbaskıyılı.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKbaskıyılı.ForeColor = System.Drawing.Color.Silver;
            this.tKbaskıyılı.Location = new System.Drawing.Point(26, 98);
            this.tKbaskıyılı.Multiline = true;
            this.tKbaskıyılı.Name = "tKbaskıyılı";
            this.tKbaskıyılı.Size = new System.Drawing.Size(192, 22);
            this.tKbaskıyılı.TabIndex = 3;
            this.tKbaskıyılı.Text = "Kitap Baskı Yılı";
            this.tKbaskıyılı.Enter += new System.EventHandler(this.tKbaskıyılı_Enter);
            this.tKbaskıyılı.Leave += new System.EventHandler(this.tKbaskıyılı_Leave);
            // 
            // tKsayısı
            // 
            this.tKsayısı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKsayısı.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKsayısı.ForeColor = System.Drawing.Color.Silver;
            this.tKsayısı.Location = new System.Drawing.Point(234, 14);
            this.tKsayısı.Multiline = true;
            this.tKsayısı.Name = "tKsayısı";
            this.tKsayısı.Size = new System.Drawing.Size(192, 22);
            this.tKsayısı.TabIndex = 4;
            this.tKsayısı.Text = "Kitap Sayfa Sayısı";
            this.tKsayısı.Enter += new System.EventHandler(this.tKsayısı_Enter);
            this.tKsayısı.Leave += new System.EventHandler(this.tKsayısı_Leave);
            // 
            // tKdili
            // 
            this.tKdili.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKdili.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKdili.ForeColor = System.Drawing.Color.Silver;
            this.tKdili.Location = new System.Drawing.Point(234, 42);
            this.tKdili.Multiline = true;
            this.tKdili.Name = "tKdili";
            this.tKdili.Size = new System.Drawing.Size(192, 22);
            this.tKdili.TabIndex = 5;
            this.tKdili.Text = "Kitap Dili";
            this.tKdili.Enter += new System.EventHandler(this.tKdili_Enter);
            this.tKdili.Leave += new System.EventHandler(this.tKdili_Leave);
            // 
            // tKyayınevi
            // 
            this.tKyayınevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tKyayınevi.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tKyayınevi.ForeColor = System.Drawing.Color.Silver;
            this.tKyayınevi.Location = new System.Drawing.Point(234, 70);
            this.tKyayınevi.Multiline = true;
            this.tKyayınevi.Name = "tKyayınevi";
            this.tKyayınevi.Size = new System.Drawing.Size(192, 22);
            this.tKyayınevi.TabIndex = 6;
            this.tKyayınevi.Text = "Kitap Yayın Evi";
            this.tKyayınevi.Enter += new System.EventHandler(this.tKyayınevi_Enter);
            this.tKyayınevi.Leave += new System.EventHandler(this.tKyayınevi_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(26, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 128);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 5);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(280, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTacıklama
            // 
            this.rTacıklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTacıklama.ForeColor = System.Drawing.Color.Silver;
            this.rTacıklama.Location = new System.Drawing.Point(445, 14);
            this.rTacıklama.Name = "rTacıklama";
            this.rTacıklama.Size = new System.Drawing.Size(181, 78);
            this.rTacıklama.TabIndex = 11;
            this.rTacıklama.Text = "Kitap Açıklama";
            this.rTacıklama.Enter += new System.EventHandler(this.rTacıklama_Enter);
            this.rTacıklama.Leave += new System.EventHandler(this.rTacıklama_Leave);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(577, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 32);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rTacıklama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tKyayınevi);
            this.Controls.Add(this.tKdili);
            this.Controls.Add(this.tKsayısı);
            this.Controls.Add(this.tKbaskıyılı);
            this.Controls.Add(this.tKyazarı);
            this.Controls.Add(this.tKadı);
            this.Controls.Add(this.tKno);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(647, 267);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tKno;
        private System.Windows.Forms.TextBox tKadı;
        private System.Windows.Forms.TextBox tKyazarı;
        private System.Windows.Forms.TextBox tKbaskıyılı;
        private System.Windows.Forms.TextBox tKsayısı;
        private System.Windows.Forms.TextBox tKdili;
        private System.Windows.Forms.TextBox tKyayınevi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rTacıklama;
        private System.Windows.Forms.Button button2;
    }
}
