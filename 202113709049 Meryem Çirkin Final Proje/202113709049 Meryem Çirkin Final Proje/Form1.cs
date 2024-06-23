using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202113709049_Meryem_Çirkin_Final_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük x 1", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta x 1.25", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük x 1.75 ", Carpan = 1.75 };
            Ebat max = new Ebat { Adi = "Max x 2", Carpan = 2 };
            cmbebat.Items.Add(kucuk);
            cmbebat.Items.Add(orta);
            cmbebat.Items.Add(buyuk);
            cmbebat.Items.Add(max);

            Pizza klasik = new Pizza { Adi = "Klasik 30TL", Fiyat = 30 };
            Pizza karisik = new Pizza { Adi = "Karışık 35TL", Fiyat = 35 };
            Pizza margarita = new Pizza { Adi = "Margarita 35TL", Fiyat = 35 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz 40TL", Fiyat = 40 };
            Pizza beyaz = new Pizza { Adi = "Beyaz Pizza 40TL", Fiyat = 40 };
            Pizza neapolitan = new Pizza { Adi = "Neapolitan 40TL", Fiyat = 40 };
            listPizzalar.Items.Add(klasik);
            listPizzalar.Items.Add(karisik);
            listPizzalar.Items.Add(margarita);
            listPizzalar.Items.Add(akdeniz);
            listPizzalar.Items.Add(beyaz);
            listPizzalar.Items.Add(neapolitan);

            KenarTip ince = new KenarTip { Adi = "İnce Kenar", EkFiyat = 0 };
            rdbİnceKenar.Tag = ince;
            KenarTip kalin = new KenarTip { Adi = "Kalın Kenar", EkFiyat = 2 };
            rdbKalinKenar.Tag = kalin;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        sipariş s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)listPizzalar.SelectedItem;
            p.Ebati =(Ebat) cmbebat.SelectedItem;
            p.KenarTipi = rdbİnceKenar.Checked ? (KenarTip) rdbİnceKenar.Tag : (KenarTip)rdbKalinKenar.Tag;
            p.Malzemeler = new List<string>();
            foreach(Control ctrl in groupBox1.Controls)
            {
                CheckBox c = (CheckBox)ctrl;
                if (c.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }
            }
            decimal tutar = nudAdet.Value * p.Tutar;
            txtTutar.Text = tutar.ToString();
            s = new sipariş();
            s.Pizza = p;
            s.Adet =(int) nudAdet.Value;
        }
        
        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                listSepet.Items.Add(s);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int adet = 0;
            foreach (sipariş spr in listSepet.Items)
            {
                toplamTutar += spr.Adet * spr.Pizza.Tutar;
                adet++;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            MessageBox.Show(string.Format("Toplam Sipariş Adediniz:{0} \n Toplam Sipariş Tutarınız:{1}", adet, toplamTutar));
        }
    }
}
