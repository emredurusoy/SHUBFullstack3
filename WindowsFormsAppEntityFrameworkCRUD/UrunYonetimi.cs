using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        void Yukle()
        {
            dgvUrunler.DataSource = context.Products.ToList();
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
                var sonuc = context.SaveChanges();
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
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilmez");
                return;
            }
            var id = (bool)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Products.Find(id);
            product.CreateDate = DateTime.Now;
            product.Name = txtUrunAdi.Text;
            product.Description = txtUrunAdi.Text;
            product.IsActive = cbDurum.Checked;
            product.Price = Convert.ToDecimal(txtUrunFiyati.Text);
            product.Stock = Convert.ToInt32(txtStok.Text);
            try
            {
                var sonuc = context.SaveChanges();
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
            var id = (bool)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            try
            {
                var sonuc = context.SaveChanges();
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
