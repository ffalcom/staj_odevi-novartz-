using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_ödevi_form
{
    public partial class frm_hmkcalculated : Form
    {
        public string islem = String.Empty;
        public double sayi1 = 0;
        public frm_hmkcalculated()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekle(object sender, EventArgs e)
        {
            txt_islemler.Text += (sender as Button).Text;
        }

        private void Islem(object sender, EventArgs e)
        {
                islem = (sender as Button).Text;
                sayi1 = Convert.ToDouble(txt_islemler.Text);

                txt_islemler.Text = " ";
            
           
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            txt_islemler.Text = " ";
            islem = String.Empty;
        }

        private void esittir_Click_1(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(txt_islemler.Text);

            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
 
                    if( sayi2 !=0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı İşlem");
                        
                    }
                    break;
                default:
                    MessageBox.Show("İşlem seçmelisiniz!", "Hata");
                    break;
            }

            txt_sonucc.Text = "Yanıt:"+ sonuc.ToString();
        }

        private void sonucc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_hmkcalculated_Load(object sender, EventArgs e)
        {
            
        }
    }
}
