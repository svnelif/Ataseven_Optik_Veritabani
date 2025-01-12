using Ataseven_Optik.BL;
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
    public partial class Siparişler : Form
    {
        public Siparişler()
        {
            InitializeComponent();
        }

      
        private void btnSiparişEkle_Click(object sender, EventArgs e)
        {
            FrmSiparis frm = new FrmSiparis()
            {
                Text = "Sipariş Ekle",
                Siparis = new Siparis() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisEkle(frm.Siparis);

                if (b)
                {

                    DataSet ds = BLogic.SiparisDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }
        private void btnSiparişBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SiparisGetir(txtBul.Text);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
              

        }

        private void btnSiparişDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmSiparis frm = new FrmSiparis()
            {
                Text = "Sipariş Düzenle",
                Güncelleme = true,
                Siparis = new Siparis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Adet = double.Parse(row.Cells[8].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[9].Value.ToString()),
                    Tarih = DateTime.Parse( row.Cells[10].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisGüncelle(frm.Siparis);

                if (b)
                {
                    row.Cells[1].Value = frm.Siparis.MusteriID;
                    row.Cells[2].Value = frm.Siparis.UrunID;
                    row.Cells[8].Value = frm.Siparis.Adet;
                    row.Cells[9].Value = frm.Siparis.Fiyat;
                    row.Cells[10].Value = frm.Siparis.Tarih;
                   

                }

            }
        }
        private void btnSiparişSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.SiparisGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }

        }


        private void Siparişler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.SiparisGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnOde_Click(object sender, EventArgs e)
        {

            Ödeme ödeme = new Ödeme();

            ödeme.Show();
           
           
        }

       
    }
}
