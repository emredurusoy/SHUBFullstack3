using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        void Yukle()
        {
            
            dgvKategoriler.DataSource = context.Categories.ToList();
            // butonları sıfırla 
            btlEkle.Enabled = true;
            BtlGüncelle.Enabled = true;
            btlSil.Enabled = true;
            
            // input ayarlarını sıfırla
            txtAciklama.Text = string.Empty;
            txtKategoriAdi.Text = string.Empty; 
            cbDurum.Checked = false;

        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btlEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text)) ;
            {
                MessageBox.Show("Kategori Adı Boş Geçmez!");
                return;
            }
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
            };
            context.Categories.Add(kategori); // ef de kategoirlere add metodu ile ekleme yapıyoruz 
            var sonuc = context.SaveChanges(); // ef de SaveChanges metodu vardır ve bu metot context üzerine yapılan eklme güncelleme silme vb işlmelri veritabanına işler ve db den etkilenen sayısını getirir 
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells[3].Value;

            btlEkle.Enabled = false;
            BtlGüncelle.Enabled = true;
            btlSil.Enabled = true;
        }

        private void BtlGüncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text)) ;
            {
                MessageBox.Show("Kategori Adı Boş Geçmez!");
                return;
            }
            var id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; // seçilen kaydın id değerini al
            var kayit = context.Categories.Find(id); // dbden bu idli kaydı bulan ef metodu find 
            // dbden bulunan kaydın bilgilerini değiştir
            kayit.Name = txtKategoriAdi.Text; 
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;
            // değişklikleri db ye işle 
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void btlSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value; // seçilen kaydın id si 
            var kayit = context.Categories.Find(id); // db den kaydı bul
            context.Categories.Remove(kayit); // kaydı silinecej olarak işaretle 
            // değişklikleri db ye işle 
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız");
            }
        }
    }
}
