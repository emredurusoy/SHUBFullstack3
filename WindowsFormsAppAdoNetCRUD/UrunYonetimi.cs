using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNetCRUD
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        UrunDAL dAL = new UrunDAL();
        void Yukle()
        {
            dgvUrunler.DataSource = dAL.GetDataTable("select * from products");
            btlEkle.Enabled = true;
            BtlGüncelle.Enabled = false;
            btlSil.Enabled = false;
        }  
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btlEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilmez");
                return;
            }
            var urun = new Product
            {
                Id = (int)dgvUrunler.CurrentRow.Cells[0].Value,
                CreateDate = DateTime.Now,
                Name = txtUrunAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Price = Convert.ToDecimal(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            };
            try
            {
                var sonuc = dAL.Add(urun);
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunler.CurrentRow.Cells[3].Value;
            txtStok.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[6].Value.ToString();

            btlEkle.Enabled = false;
            BtlGüncelle.Enabled = true;
            btlSil.Enabled = true;
        }

        private void BtlGüncelle_Click(object sender, EventArgs e)
        {
          
            var urun = new Product
            {
                Id = (int)dgvUrunler.CurrentRow.Cells [0].Value,
                CreateDate = DateTime.Now,
                Name = txtUrunAdi.Text,
                Description = txtUrunAdi.Text,
                IsActive = cbDurum.Checked,
                Price = Convert.ToDecimal(txtUrunFiyati.Text),
                Stock = Convert.ToInt32(txtStok.Text)
            };
            try
            {
                var sonuc = dAL.Update(urun);
                if (sonuc > 0) 
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void btlSil_Click(object sender, EventArgs e)
        {
            var urun = new Product
            {
                Id = (int)dgvUrunler.CurrentRow.Cells[0].Value
            };
           
            try
            {
                var sonuc = dAL.Delete(urun);
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Silme Başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Silme Başarısız");
            }
        }
    }
    
}
