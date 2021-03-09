
namespace staj_ödevi_form
{
    partial class frm_hmkcalculated
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hmkcalculated));
            this.btn_sıfır = new System.Windows.Forms.Button();
            this.btn_bir = new System.Windows.Forms.Button();
            this.btn_iki = new System.Windows.Forms.Button();
            this.btn_uc = new System.Windows.Forms.Button();
            this.btn_dort = new System.Windows.Forms.Button();
            this.btn_bes = new System.Windows.Forms.Button();
            this.btn_altı = new System.Windows.Forms.Button();
            this.btn_yedi = new System.Windows.Forms.Button();
            this.btn_sekiz = new System.Windows.Forms.Button();
            this.btn_virgül = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_cıkartma = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.btn_dokuz = new System.Windows.Forms.Button();
            this.txt_islemler = new System.Windows.Forms.TextBox();
            this.txt_sonucc = new System.Windows.Forms.TextBox();
            this.fıxed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sıfır
            // 
            this.btn_sıfır.BackColor = System.Drawing.Color.Khaki;
            this.btn_sıfır.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıfır.Location = new System.Drawing.Point(239, 423);
            this.btn_sıfır.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sıfır.Name = "btn_sıfır";
            this.btn_sıfır.Size = new System.Drawing.Size(104, 61);
            this.btn_sıfır.TabIndex = 0;
            this.btn_sıfır.Text = "0";
            this.btn_sıfır.UseVisualStyleBackColor = false;
            this.btn_sıfır.Click += new System.EventHandler(this.ekle);
            // 
            // btn_bir
            // 
            this.btn_bir.BackColor = System.Drawing.Color.Khaki;
            this.btn_bir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bir.Location = new System.Drawing.Point(239, 212);
            this.btn_bir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_bir.Name = "btn_bir";
            this.btn_bir.Size = new System.Drawing.Size(104, 61);
            this.btn_bir.TabIndex = 1;
            this.btn_bir.Text = "1";
            this.btn_bir.UseVisualStyleBackColor = false;
            this.btn_bir.Click += new System.EventHandler(this.ekle);
            // 
            // btn_iki
            // 
            this.btn_iki.BackColor = System.Drawing.Color.Khaki;
            this.btn_iki.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iki.Location = new System.Drawing.Point(365, 212);
            this.btn_iki.Margin = new System.Windows.Forms.Padding(5);
            this.btn_iki.Name = "btn_iki";
            this.btn_iki.Size = new System.Drawing.Size(104, 61);
            this.btn_iki.TabIndex = 2;
            this.btn_iki.Text = "2";
            this.btn_iki.UseVisualStyleBackColor = false;
            this.btn_iki.Click += new System.EventHandler(this.ekle);
            // 
            // btn_uc
            // 
            this.btn_uc.BackColor = System.Drawing.Color.Khaki;
            this.btn_uc.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uc.Location = new System.Drawing.Point(478, 212);
            this.btn_uc.Margin = new System.Windows.Forms.Padding(5);
            this.btn_uc.Name = "btn_uc";
            this.btn_uc.Size = new System.Drawing.Size(104, 61);
            this.btn_uc.TabIndex = 3;
            this.btn_uc.Text = "3";
            this.btn_uc.UseVisualStyleBackColor = false;
            this.btn_uc.Click += new System.EventHandler(this.ekle);
            // 
            // btn_dort
            // 
            this.btn_dort.BackColor = System.Drawing.Color.Khaki;
            this.btn_dort.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dort.Location = new System.Drawing.Point(239, 282);
            this.btn_dort.Margin = new System.Windows.Forms.Padding(5);
            this.btn_dort.Name = "btn_dort";
            this.btn_dort.Size = new System.Drawing.Size(104, 61);
            this.btn_dort.TabIndex = 4;
            this.btn_dort.Text = "4";
            this.btn_dort.UseVisualStyleBackColor = false;
            this.btn_dort.Click += new System.EventHandler(this.ekle);
            // 
            // btn_bes
            // 
            this.btn_bes.BackColor = System.Drawing.Color.Khaki;
            this.btn_bes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bes.Location = new System.Drawing.Point(365, 282);
            this.btn_bes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_bes.Name = "btn_bes";
            this.btn_bes.Size = new System.Drawing.Size(104, 61);
            this.btn_bes.TabIndex = 5;
            this.btn_bes.Text = "5";
            this.btn_bes.UseVisualStyleBackColor = false;
            this.btn_bes.Click += new System.EventHandler(this.ekle);
            // 
            // btn_altı
            // 
            this.btn_altı.BackColor = System.Drawing.Color.Khaki;
            this.btn_altı.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_altı.Location = new System.Drawing.Point(478, 282);
            this.btn_altı.Margin = new System.Windows.Forms.Padding(5);
            this.btn_altı.Name = "btn_altı";
            this.btn_altı.Size = new System.Drawing.Size(104, 61);
            this.btn_altı.TabIndex = 6;
            this.btn_altı.Text = "6";
            this.btn_altı.UseVisualStyleBackColor = false;
            this.btn_altı.Click += new System.EventHandler(this.ekle);
            // 
            // btn_yedi
            // 
            this.btn_yedi.BackColor = System.Drawing.Color.Khaki;
            this.btn_yedi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yedi.Location = new System.Drawing.Point(239, 352);
            this.btn_yedi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_yedi.Name = "btn_yedi";
            this.btn_yedi.Size = new System.Drawing.Size(104, 61);
            this.btn_yedi.TabIndex = 7;
            this.btn_yedi.Text = "7";
            this.btn_yedi.UseVisualStyleBackColor = false;
            this.btn_yedi.Click += new System.EventHandler(this.ekle);
            // 
            // btn_sekiz
            // 
            this.btn_sekiz.BackColor = System.Drawing.Color.Khaki;
            this.btn_sekiz.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sekiz.Location = new System.Drawing.Point(365, 352);
            this.btn_sekiz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sekiz.Name = "btn_sekiz";
            this.btn_sekiz.Size = new System.Drawing.Size(104, 61);
            this.btn_sekiz.TabIndex = 8;
            this.btn_sekiz.Text = "8";
            this.btn_sekiz.UseVisualStyleBackColor = false;
            this.btn_sekiz.Click += new System.EventHandler(this.ekle);
            // 
            // btn_virgül
            // 
            this.btn_virgül.BackColor = System.Drawing.Color.Khaki;
            this.btn_virgül.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_virgül.Location = new System.Drawing.Point(365, 423);
            this.btn_virgül.Margin = new System.Windows.Forms.Padding(5);
            this.btn_virgül.Name = "btn_virgül";
            this.btn_virgül.Size = new System.Drawing.Size(104, 61);
            this.btn_virgül.TabIndex = 10;
            this.btn_virgül.Text = ",";
            this.btn_virgül.UseVisualStyleBackColor = false;
            this.btn_virgül.Click += new System.EventHandler(this.ekle);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Khaki;
            this.btn_temizle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(478, 423);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(104, 61);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "C";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.BackColor = System.Drawing.Color.Khaki;
            this.btn_bolme.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bolme.Location = new System.Drawing.Point(591, 352);
            this.btn_bolme.Margin = new System.Windows.Forms.Padding(5);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(104, 61);
            this.btn_bolme.TabIndex = 12;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = false;
            this.btn_bolme.Click += new System.EventHandler(this.Islem);
            // 
            // btn_toplama
            // 
            this.btn_toplama.BackColor = System.Drawing.Color.Khaki;
            this.btn_toplama.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplama.Location = new System.Drawing.Point(591, 212);
            this.btn_toplama.Margin = new System.Windows.Forms.Padding(5);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(104, 61);
            this.btn_toplama.TabIndex = 13;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = false;
            this.btn_toplama.Click += new System.EventHandler(this.Islem);
            // 
            // btn_cıkartma
            // 
            this.btn_cıkartma.BackColor = System.Drawing.Color.Khaki;
            this.btn_cıkartma.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkartma.Location = new System.Drawing.Point(591, 282);
            this.btn_cıkartma.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cıkartma.Name = "btn_cıkartma";
            this.btn_cıkartma.Size = new System.Drawing.Size(104, 61);
            this.btn_cıkartma.TabIndex = 14;
            this.btn_cıkartma.Text = "-";
            this.btn_cıkartma.UseVisualStyleBackColor = false;
            this.btn_cıkartma.Click += new System.EventHandler(this.Islem);
            // 
            // btn_carpma
            // 
            this.btn_carpma.BackColor = System.Drawing.Color.Khaki;
            this.btn_carpma.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carpma.Location = new System.Drawing.Point(591, 423);
            this.btn_carpma.Margin = new System.Windows.Forms.Padding(5);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(104, 61);
            this.btn_carpma.TabIndex = 15;
            this.btn_carpma.Text = "*";
            this.btn_carpma.UseVisualStyleBackColor = false;
            this.btn_carpma.Click += new System.EventHandler(this.Islem);
            // 
            // btn_esittir
            // 
            this.btn_esittir.BackColor = System.Drawing.Color.Khaki;
            this.btn_esittir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_esittir.Location = new System.Drawing.Point(552, 493);
            this.btn_esittir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(160, 61);
            this.btn_esittir.TabIndex = 16;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = false;
            this.btn_esittir.Click += new System.EventHandler(this.esittir_Click_1);
            // 
            // btn_dokuz
            // 
            this.btn_dokuz.BackColor = System.Drawing.Color.Khaki;
            this.btn_dokuz.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dokuz.Location = new System.Drawing.Point(478, 352);
            this.btn_dokuz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_dokuz.Name = "btn_dokuz";
            this.btn_dokuz.Size = new System.Drawing.Size(104, 61);
            this.btn_dokuz.TabIndex = 17;
            this.btn_dokuz.Text = "9";
            this.btn_dokuz.UseVisualStyleBackColor = false;
            this.btn_dokuz.Click += new System.EventHandler(this.ekle);
            // 
            // txt_islemler
            // 
            this.txt_islemler.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.txt_islemler.Location = new System.Drawing.Point(239, 149);
            this.txt_islemler.Margin = new System.Windows.Forms.Padding(5);
            this.txt_islemler.Name = "txt_islemler";
            this.txt_islemler.Size = new System.Drawing.Size(471, 42);
            this.txt_islemler.TabIndex = 18;
            this.txt_islemler.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_sonucc
            // 
            this.txt_sonucc.Enabled = false;
            this.txt_sonucc.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sonucc.Location = new System.Drawing.Point(722, 325);
            this.txt_sonucc.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sonucc.Name = "txt_sonucc";
            this.txt_sonucc.Size = new System.Drawing.Size(215, 42);
            this.txt_sonucc.TabIndex = 19;
            this.txt_sonucc.Click += new System.EventHandler(this.ekle);
            this.txt_sonucc.TextChanged += new System.EventHandler(this.sonucc_TextChanged);
            // 
            // fıxed
            // 
            this.fıxed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fıxed.BackgroundImage")));
            this.fıxed.Location = new System.Drawing.Point(-3, -3);
            this.fıxed.Name = "fıxed";
            this.fıxed.Size = new System.Drawing.Size(1008, 686);
            this.fıxed.TabIndex = 20;
            this.fıxed.UseVisualStyleBackColor = true;
            // 
            // frm_hmkcalculated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 675);
            this.Controls.Add(this.txt_sonucc);
            this.Controls.Add(this.txt_islemler);
            this.Controls.Add(this.btn_dokuz);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_cıkartma);
            this.Controls.Add(this.btn_toplama);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_virgül);
            this.Controls.Add(this.btn_sekiz);
            this.Controls.Add(this.btn_yedi);
            this.Controls.Add(this.btn_altı);
            this.Controls.Add(this.btn_bes);
            this.Controls.Add(this.btn_dort);
            this.Controls.Add(this.btn_uc);
            this.Controls.Add(this.btn_iki);
            this.Controls.Add(this.btn_bir);
            this.Controls.Add(this.btn_sıfır);
            this.Controls.Add(this.fıxed);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_hmkcalculated";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.frm_hmkcalculated_Load);
            this.Click += new System.EventHandler(this.Islem);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sıfır;
        private System.Windows.Forms.Button btn_bir;
        private System.Windows.Forms.Button btn_iki;
        private System.Windows.Forms.Button btn_uc;
        private System.Windows.Forms.Button btn_dort;
        private System.Windows.Forms.Button btn_bes;
        private System.Windows.Forms.Button btn_altı;
        private System.Windows.Forms.Button btn_yedi;
        private System.Windows.Forms.Button btn_sekiz;
        private System.Windows.Forms.Button btn_virgül;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_cıkartma;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_esittir;
        private System.Windows.Forms.Button btn_dokuz;
        private System.Windows.Forms.TextBox txt_islemler;
        private System.Windows.Forms.TextBox txt_sonucc;
        private System.Windows.Forms.Button fıxed;
    }
}

