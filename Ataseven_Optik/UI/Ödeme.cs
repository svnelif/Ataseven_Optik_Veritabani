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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }

        private void Ödeme_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.OdemeGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Ödeme Ekle",
                Odeme= new Odeme() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.Odeme);

                if (b)
                {

                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnOdemeBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OdemeGetir(txtBul.Text);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnOdemeDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Ödeme Düzenle",
                Güncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                   Tutar= double.Parse(row.Cells[4].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                   

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGüncelle(frm.Odeme);

                if (b)
                {
                    row.Cells[1].Value = frm.Odeme.MusteriID;
                    row.Cells[3].Value = frm.Odeme.Tarih;
                    row.Cells[4].Value = frm.Odeme.Tutar;
                    row.Cells[5].Value = frm.Odeme.Tur;


                }

            }
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.odemeSil(ID);

                if (b)
                {

                    DataSet ds = BLogic.OdemeGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }
    }
}
