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
    public partial class OgrenciGiris : Form
    {

        OgreniDers ogreniDers;
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        IdareDBEntities db = new IdareDBEntities();

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz");
                return;
            }
            if (txtkayit.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kayıt Tarihini Giriniz");
                return;
            }
            if (txtno.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Öğrenci Numarasını Giriniz");
                return;
            }
            if (dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Doğum Tarihini Giriniz");
                return;
            }
            if (txtbolüm.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bölüm Giriniz");
                return;
            }
            try
            {
                var ctx = new IdareDBEntities();
                var ogrenciTablo = new OgrenciTablo()
                {
                    AdSoyad= txtadsoyad.Text,
                    KayitTarih = Convert.ToInt32(txtkayit.Text),
                    OgrenciNo = Convert.ToInt32(txtno.Text),
                    DTarih = DateTime.Now,
                    Bolum =txtbolüm.Text,
                };
                ctx.OgrenciTabloes.Add(ogrenciTablo);
                ctx.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla kaydedilmiştir :) ");
                txtadsoyad.Text = string.Empty;
                txtkayit.Text = string.Empty;
                txtno.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                txtbolüm.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken bir sorun oluştu !! => " + ex.ToString());
            }
        }
    }
}
