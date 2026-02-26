namespace WindowsFormsAppAdoNetCRUD
{
    partial class KategoriYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.btlEkle = new System.Windows.Forms.Button();
            this.BtlGüncelle = new System.Windows.Forms.Button();
            this.btlSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btlSil);
            this.groupBox1.Controls.Add(this.BtlGüncelle);
            this.groupBox1.Controls.Add(this.btlEkle);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.txtKategoriAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(104, 31);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durum";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(104, 70);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 2;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açıklama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(322, 37);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(215, 103);
            this.txtAciklama.TabIndex = 4;
            this.txtAciklama.Text = "";
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(21, 22);
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.RowHeadersWidth = 51;
            this.dgvKategoriler.RowTemplate.Height = 24;
            this.dgvKategoriler.Size = new System.Drawing.Size(754, 219);
            this.dgvKategoriler.TabIndex = 1;
            // 
            // btlEkle
            // 
            this.btlEkle.Location = new System.Drawing.Point(20, 117);
            this.btlEkle.Name = "btlEkle";
            this.btlEkle.Size = new System.Drawing.Size(75, 23);
            this.btlEkle.TabIndex = 5;
            this.btlEkle.Text = "Ekle";
            this.btlEkle.UseVisualStyleBackColor = true;
            this.btlEkle.Click += new System.EventHandler(this.btlEkle_Click);
            // 
            // BtlGüncelle
            // 
            this.BtlGüncelle.Location = new System.Drawing.Point(115, 117);
            this.BtlGüncelle.Name = "BtlGüncelle";
            this.BtlGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtlGüncelle.TabIndex = 5;
            this.BtlGüncelle.Text = "Güncelle ";
            this.BtlGüncelle.UseVisualStyleBackColor = true;
            // 
            // btlSil
            // 
            this.btlSil.Location = new System.Drawing.Point(213, 117);
            this.btlSil.Name = "btlSil";
            this.btlSil.Size = new System.Drawing.Size(75, 23);
            this.btlSil.TabIndex = 5;
            this.btlSil.Text = "Sil";
            this.btlSil.UseVisualStyleBackColor = true;
            // 
            // KategoriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.dgvKategoriler);
            this.Controls.Add(this.groupBox1);
            this.Name = "KategoriYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi";
            this.Load += new System.EventHandler(this.KategoriYonetimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Button btlEkle;
        private System.Windows.Forms.Button btlSil;
        private System.Windows.Forms.Button BtlGüncelle;
    }
}