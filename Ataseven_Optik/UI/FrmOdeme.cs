using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ataseven_Optik.UI
{
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }
        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen fiyat giriniz!");
                nmTutar.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }
            Odeme.MusteriID = Guid.Parse(txtMusteri.Text);
            Odeme.Tarih = dtTarih.Value;
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Tur = cmTur.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Odeme.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Odeme.MusteriID.ToString();              
                nmTutar.Value = (decimal)Odeme.Tutar;
                dtTarih.Value = Odeme.Tarih;
                cmTur.Text = Odeme.Tur;
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }
    }
    
}
