using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselFinal.Forms
{
    public partial class OgrenciListe : Form
    {
        public OgrenciListe()
        {
            InitializeComponent();
        }

        IdareDBEntities db = new IdareDBEntities();


        private void OgrenciListe_Load(object sender, EventArgs e)
        {
            var ctx = new IdareDBEntities();
            var ogrenciTablos = ctx.OgrenciTabloes.ToList();
            var bindingList = new BindingList<OgrenciTablo>(ogrenciTablos);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) >= 1900)
                {
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.Black;
                }

                else
                {
                    renk.BackColor = Color.Yellow;
                    renk.ForeColor = Color.Black;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingSource1.RemoveCurrent();
   
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Güncelle")
            {
                if (MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingSource1.CurrentChanged += BindingSource1_CurrentChanged; 

            }

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
