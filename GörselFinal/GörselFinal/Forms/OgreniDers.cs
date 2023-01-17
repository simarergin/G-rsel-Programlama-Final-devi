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
    public partial class OgreniDers : Form
    {
        public OgreniDers()
        {
            InitializeComponent();
        }

        IdareDBEntities db = new IdareDBEntities();

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

        private void OgreniDers_Load(object sender, EventArgs e)
        {
            var ctx = new IdareDBEntities();
            var ogrenciDersTablos = ctx.OgrenciDersTabloes.ToList();
            var bindingList = new BindingList<OgrenciDersTablo>(ogrenciDersTablos);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
