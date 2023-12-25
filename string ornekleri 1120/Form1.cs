using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_ornekleri_1120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string Mesaj = lblMesaj.Text;
            lblMesaj.Text = Mesaj.ToUpper();

        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string Mesaj = lblMesaj.Text;
            lblMesaj.Text = Mesaj.ToLower();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MesageBox.Show("Toplam karakter"+lblMesaj.Text.lenht+"Karakter Vardır");
            string mesaj = $"toplam{lblMesaj.Text.Length} karakter vardır.";
            MessageBox.Show(mesaj);

        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"Merhaba dünya, ben{txtMesaj.Text}!";
        }

        private void btnBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "merhaba dünya";
            string mesaj2 = "ben rabia";

            // string yeniMesaj1 = mesaj1 + mesaj2 ;
            string yeniMesa = string.Concat(mesaj1, mesaj2);

            lblMesaj.Text = yeniMesa;   
        }

        private void btnSiraGetir_Click(object sender, EventArgs e)
        {
            //5.sıradaki harfi getir  

            string mesaj = lblMesaj.Text;
            //mesaj[4] //char türüdür

            MessageBox.Show($"6. sıradaki harf  :{mesaj[5]}");
        }

        private void btnKacis_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba ben \"Rabia \".\rNasılsın?";
            lblMesaj.Text = mesaj;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "ilayda";
            string isim2 = "ilayda";
            string isim3 = "sema";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim1.Equals(isim2);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum :{durum1}--> durum2 {durum2} /rdurum :{durum3} --> durum4 .{durum4}";
            MessageBox.Show(mesaj);
        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 200;
            string mesaj = $"{a} + {b} = {c}";
            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = " Rabia"; 
            string isim2 = " Rabia";
            string isim3 = " Ayşe";
            string isim4 = " Zeynep";
            string isim5 = "rabia";

            int sonuc1 = String.Compare(isim1, isim2);//0
            int sonuc2 =String.Compare(isim1, isim3); //1
            int sonuc3 = String.Compare(isim1, isim4);//-1
            int sonuc4 = String.Compare(isim1, isim5);//1
            int sonuc5 = String.Compare(isim1, isim2, true);//0

            //MessageBox.Show( $"Sonuç :{sonuç}");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4);
            //başlangıç ,adet

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text}......{durum}");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("rabia", txtMesaj.Text);
            lblMesaj.Text = mesaj; 
        }
    }
}
