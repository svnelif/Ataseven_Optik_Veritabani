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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Urun Urun { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtMarka)) return;
            if (!ErrorControl(txtModel)) return;
            if (!ErrorControl(txtRenk)) return;
            if (!ErrorControl(txtNumara)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;

            Urun.Marka = txtMarka.Text;
            Urun.Model = txtModel.Text;
            Urun.Renk = txtRenk.Text;
            Urun.Numara= txtNumara.Text;
            Urun.Fiyat = (double)nmFiyat.Value;
            Urun.Stok = (double)nmStok.Value;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            txtID.Text = Urun.ID.ToString();
            if (Güncelleme)
            {
                Urun.Marka = txtMarka.Text;
                Urun.Model = txtModel.Text;
                Urun.Renk = txtRenk.Text;
                Urun.Numara = txtNumara.Text;
                Urun.Fiyat = (double)nmFiyat.Value;
                Urun.Stok = (double)nmStok.Value;

            }

        }
    }
}
