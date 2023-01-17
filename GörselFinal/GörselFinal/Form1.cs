using GörselFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Close();
            //close ile sistem tamamen kapanırken hide ile winform kapansa bile çalışır halde oluyor.
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersGiris g = new DersGiris();
            g.MdiParent = this.ParentForm;
            g.Show();
            toolStripStatusLabel1.Text = "Ders Giriş Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListe l = new DersListe();
            l.MdiParent = this.ParentForm;
            l.Show();
            toolStripStatusLabel1.Text = "Ders Listele Formuna Tıklandı";
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelGiris p = new PersonelGiris();
            p.MdiParent = this.ParentForm;
            p.Show();
            toolStripStatusLabel1.Text = "Personel Giriş Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelListe s = new PersonelListe();
            s.MdiParent = this.ParentForm;
            s.Show();
            toolStripStatusLabel1.Text = "Personel Listele Formuna Tıklandı";
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciGiris r = new OgrenciGiris();
            r.MdiParent = this.ParentForm;
            r.Show();
            toolStripStatusLabel1.Text = "Öğrenci Giriş Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciListe o = new OgrenciListe();
            o.MdiParent = this.ParentForm;
            o.Show();
            toolStripStatusLabel1.Text = "Öğrenci Listele Formuna Tıklandı";
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgreniDers o = new OgreniDers();
            o.MdiParent = this.ParentForm;
            o.Show();
            toolStripStatusLabel1.Text = "Öğrenci Ders Formuna Tıklandı";
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //yorum satırında olmalarının sebebi hangisi açılırsa combobox ile seçilip buttona basıldığında o getiriliyor.


            DersGiris s = new DersGiris();
            s.MdiParent = this.ParentForm;
            s.Show();
            DersListe q = new DersListe();
            q.MdiParent = this.ParentForm;
            q.Show();
            // PersonelGiris o = new PersonelGiris();
            // o.MdiParent = this.ParentForm;
            // o.Show();
            // PersonelListe x = new PersonelListe();
            // x.MdiParent = this.ParentForm;
            // x.Show();
            //OgrenciGiris k = new OgrenciGiris();
            //k.MdiParent = this.ParentForm;
            //k.Show();
            //OgrenciListe ç = new OgrenciListe();
            //ç.MdiParent = this.ParentForm;
            //ç.Show();
        }
    }
}
