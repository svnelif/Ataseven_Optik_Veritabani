using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ataseven_Optik.UI
{
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        public Siparis Siparis { get; set; }
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

            Siparis.Tarih = dtTarih.Value;
            Siparis.Adet = (double)nmAdet.Value;
            Siparis.Fiyat = (double)nmTutar.Value;
            Siparis.UrunID = Guid.Parse(txtUrun.Text);
            Siparis.MusteriID = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void FrmSiparis_Load(object sender, EventArgs e)
        {

            txtID.Text = Siparis.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Siparis.MusteriID.ToString();
                txtUrun.Text = Siparis.UrunID.ToString();
                nmTutar.Value = (decimal)Siparis.Fiyat;
                dtTarih.Value = Siparis.Tarih;
                nmAdet.Value = (decimal)Siparis.Adet;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUrun.Text = frm.ürün.ID.ToString();
            }

        }
    }
}
