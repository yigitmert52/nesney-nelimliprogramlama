using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProjeHastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePickerRandevuTarihi.Value;
            string hastaAdi = txtHastaAdi.Text;
            string doktorAdi = txtDoktorAdi.Text;

            IRandevu randevu = new Randevu
            {
                Tarih = tarih,
                HastaAdi = hastaAdi,
                DoktorAdi = doktorAdi
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
