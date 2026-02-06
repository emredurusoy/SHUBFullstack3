using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // bu metot form açılırken çalışır
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);
            }
            comboBox1.DataSource = domainUpDown1.Items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Butona Tıkladınız";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else 
            {
                button1.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            if (txtKulaniciAdi.Text == "Admin" && txtSifre.Text == "adm123")
            {
                label1.Text = "Hoş Geldin Admin";
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!"); //kısayolu mbox tab tab: ekrana mesaj vermenizi sağlar 
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)// ekrandaki numerupdown nesnesi değeri değiştirdiğinde çalışacak olan metot 
        {
            label1.Font = new Font(comboBox1.SelectedValue.ToString(), (float)numericUpDown1.Value); // ekrandaki label isimli nesnenin font değerini yeni bir fontla değiştirir. Yeni fontu yine ekranda içine sistemindeki fontları yüklediğimiz combox isimli nesnede seçili olan fontu  2. parametrede ise bu yazı fontunun boyutunu numericupdown nesnesini seçişi değerden alarak ayrla dedik 


        }
    }
}