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
    public partial class DersGiris : Form
    {
        public DersGiris()
        {
            InitializeComponent();
        }

        IdareDBEntities db = new IdareDBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Ad Giriniz");
                return;
            }
            if (txtkredi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Dersin Kredisini Giriniz");
                return;
            }
            if (txtogretmen.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Dersin Öğretmenini Giriniz");
                return;
            }
            try
            {
                var ctx = new IdareDBEntities();
                var dersTablo = new DersTablo()
                {
                    Ad = txtad.Text,
                    Kredisi = Convert.ToDouble(txtkredi.Text),
                    OkulYonetimId = Convert.ToInt32(txtogretmen.Text),
                };
                ctx.DersTabloes.Add(dersTablo);
                ctx.SaveChanges();
                MessageBox.Show("Ders başarıyla kaydedilmiştir :) ");
                txtad.Text = string.Empty;
                txtkredi.Text = string.Empty;
                txtogretmen.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken bir sorun oluştu !! => " + ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Hide();
        }
    }
}
