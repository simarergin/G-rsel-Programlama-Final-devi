using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselFinal.Forms
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        IdareDBEntities db = new IdareDBEntities();

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Id Giriniz");
                return;
            }
            if (txtadsoyad.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz");
                return;
            }
            if (txtgorevi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Görevi Giriniz");
                return;
            }
            if (txtyönetim.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Yönetim Tipini Giriniz");
                return;
            }
            try
            {
                var ctx = new IdareDBEntities();
                var okulYonetim = new OkulYonetimTablo()
                {
                    AdSoyad = txtadsoyad.Text,
                    Gorevi = txtgorevi.Text,
                    YonetimTip = Convert.ToInt32(txtyönetim.Text),
                };
                ctx.OkulYonetimTabloes.Add(okulYonetim);
                ctx.SaveChanges();
                MessageBox.Show("Personel başarıyla kaydedilmiştir :) ");
                txtadsoyad.Text = string.Empty;
                txtgorevi.Text = string.Empty;
                txtyönetim.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken bir sorun oluştu !! => " + ex.ToString());
            }
        }
    }
}
