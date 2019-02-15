using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormWCFapp.ServiceReference1;

namespace WindowsFormWCFapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Musteri m1 = new Musteri();
            m1.adSoyad = txt_musAdSoyad.Text;
            m1.yas = Convert.ToInt32(txt_yas.Text);
            m1.cinsiuet = txt_cinsiyet.Text;

            Service1Client srvs = new Service1Client();
            if (srvs.MusteriEkle(m1) == 1)
            {
                MessageBox.Show("Kayıt Basarılı...");
            }
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Musteri m2 = new Musteri();
            m2.musID = int.Parse(txt_musNo.Text);

            Service1Client srvs2 = new Service1Client();
            if (srvs2.MusteriSil(m2) == 1)
            {
                MessageBox.Show("Silme işlemi başarılı...");
            }

        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            Musteri m3 = new Musteri();
            Service1Client srvs3 = new Service1Client();
            dataGridView1.DataSource = srvs3.MusteriGetir(m3);
        }
    }
}
