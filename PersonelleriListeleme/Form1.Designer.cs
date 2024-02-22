namespace PersonelleriListeleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.adSoyad = new System.Windows.Forms.Label();
            this.il = new System.Windows.Forms.Label();
            this.ilce = new System.Windows.Forms.Label();
            this.uzaktan = new System.Windows.Forms.Label();
            this.yuzyuze = new System.Windows.Forms.Label();
            this.yurticiDeneyim = new System.Windows.Forms.Label();
            this.yurtdisiDeneyim = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.Label();
            this.telNo = new System.Windows.Forms.Label();
            this.ekip = new System.Windows.Forms.Label();
            this.proje = new System.Windows.Forms.Label();
            this.personelId = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.textBoxpersonelId = new System.Windows.Forms.TextBox();
            this.textBoxadSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.comboBoxuzaktan = new System.Windows.Forms.ComboBox();
            this.comboBoxyuzyuze = new System.Windows.Forms.ComboBox();
            this.comboBoxyurtici = new System.Windows.Forms.ComboBox();
            this.comboBoxyurtdisi = new System.Windows.Forms.ComboBox();
            this.textBoxtelNo = new System.Windows.Forms.TextBox();
            this.comboBoxekip = new System.Windows.Forms.ComboBox();
            this.comboBoxproje = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxmaas = new System.Windows.Forms.TextBox();
            this.yurtdisibutton = new System.Windows.Forms.Button();
            this.yurticibutton = new System.Windows.Forms.Button();
            this.kayitliPersonelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Location = new System.Drawing.Point(26, 51);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(70, 16);
            this.adSoyad.TabIndex = 1;
            this.adSoyad.Text = "Ad Soyad:";
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Location = new System.Drawing.Point(52, 96);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(19, 16);
            this.il.TabIndex = 2;
            this.il.Text = "İl: ";
            // 
            // ilce
            // 
            this.ilce.AutoSize = true;
            this.ilce.Location = new System.Drawing.Point(52, 134);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(31, 16);
            this.ilce.TabIndex = 3;
            this.ilce.Text = "İlçe:";
            // 
            // uzaktan
            // 
            this.uzaktan.AutoSize = true;
            this.uzaktan.Location = new System.Drawing.Point(37, 170);
            this.uzaktan.Name = "uzaktan";
            this.uzaktan.Size = new System.Drawing.Size(59, 16);
            this.uzaktan.TabIndex = 4;
            this.uzaktan.Text = "Uzaktan:";
            // 
            // yuzyuze
            // 
            this.yuzyuze.AutoSize = true;
            this.yuzyuze.Location = new System.Drawing.Point(37, 200);
            this.yuzyuze.Name = "yuzyuze";
            this.yuzyuze.Size = new System.Drawing.Size(60, 16);
            this.yuzyuze.TabIndex = 5;
            this.yuzyuze.Text = "Yüzyüze:";
            // 
            // yurticiDeneyim
            // 
            this.yurticiDeneyim.AutoSize = true;
            this.yurticiDeneyim.Location = new System.Drawing.Point(569, 18);
            this.yurticiDeneyim.Name = "yurticiDeneyim";
            this.yurticiDeneyim.Size = new System.Drawing.Size(103, 16);
            this.yurticiDeneyim.TabIndex = 6;
            this.yurticiDeneyim.Text = "Yurtiçi Deneyim:";
            // 
            // yurtdisiDeneyim
            // 
            this.yurtdisiDeneyim.AutoSize = true;
            this.yurtdisiDeneyim.Location = new System.Drawing.Point(558, 54);
            this.yurtdisiDeneyim.Name = "yurtdisiDeneyim";
            this.yurtdisiDeneyim.Size = new System.Drawing.Size(114, 16);
            this.yurtdisiDeneyim.TabIndex = 7;
            this.yurtdisiDeneyim.Text = "Yurtdışı Deneyim: ";
            // 
            // maas
            // 
            this.maas.AutoSize = true;
            this.maas.Location = new System.Drawing.Point(619, 88);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(47, 16);
            this.maas.TabIndex = 8;
            this.maas.Text = "Maaş: ";
            // 
            // telNo
            // 
            this.telNo.AutoSize = true;
            this.telNo.Location = new System.Drawing.Point(595, 131);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(77, 16);
            this.telNo.TabIndex = 9;
            this.telNo.Text = "Telefon No:";
            // 
            // ekip
            // 
            this.ekip.AutoSize = true;
            this.ekip.Location = new System.Drawing.Point(619, 167);
            this.ekip.Name = "ekip";
            this.ekip.Size = new System.Drawing.Size(40, 16);
            this.ekip.TabIndex = 10;
            this.ekip.Text = "Ekip: ";
            // 
            // proje
            // 
            this.proje.AutoSize = true;
            this.proje.Location = new System.Drawing.Point(619, 204);
            this.proje.Name = "proje";
            this.proje.Size = new System.Drawing.Size(42, 16);
            this.proje.TabIndex = 11;
            this.proje.Text = "Proje:";
            // 
            // personelId
            // 
            this.personelId.AutoSize = true;
            this.personelId.Location = new System.Drawing.Point(18, 20);
            this.personelId.Name = "personelId";
            this.personelId.Size = new System.Drawing.Size(78, 16);
            this.personelId.TabIndex = 12;
            this.personelId.Text = "Personel Id:";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(12, 245);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(126, 74);
            this.ekle.TabIndex = 13;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(157, 245);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(130, 74);
            this.sil.TabIndex = 14;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(304, 245);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(108, 74);
            this.guncelle.TabIndex = 15;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(431, 245);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(132, 74);
            this.listele.TabIndex = 16;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // textBoxpersonelId
            // 
            this.textBoxpersonelId.Location = new System.Drawing.Point(116, 17);
            this.textBoxpersonelId.Name = "textBoxpersonelId";
            this.textBoxpersonelId.Size = new System.Drawing.Size(312, 22);
            this.textBoxpersonelId.TabIndex = 17;
            // 
            // textBoxadSoyad
            // 
            this.textBoxadSoyad.Location = new System.Drawing.Point(116, 51);
            this.textBoxadSoyad.Name = "textBoxadSoyad";
            this.textBoxadSoyad.Size = new System.Drawing.Size(312, 22);
            this.textBoxadSoyad.TabIndex = 18;
            // 
            // comboBoxil
            // 
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(116, 88);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(312, 24);
            this.comboBoxil.TabIndex = 19;
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(116, 126);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(312, 24);
            this.comboBoxilce.TabIndex = 20;
            // 
            // comboBoxuzaktan
            // 
            this.comboBoxuzaktan.FormattingEnabled = true;
            this.comboBoxuzaktan.Location = new System.Drawing.Point(116, 161);
            this.comboBoxuzaktan.Name = "comboBoxuzaktan";
            this.comboBoxuzaktan.Size = new System.Drawing.Size(312, 24);
            this.comboBoxuzaktan.TabIndex = 21;
            // 
            // comboBoxyuzyuze
            // 
            this.comboBoxyuzyuze.FormattingEnabled = true;
            this.comboBoxyuzyuze.Location = new System.Drawing.Point(116, 197);
            this.comboBoxyuzyuze.Name = "comboBoxyuzyuze";
            this.comboBoxyuzyuze.Size = new System.Drawing.Size(312, 24);
            this.comboBoxyuzyuze.TabIndex = 22;
            // 
            // comboBoxyurtici
            // 
            this.comboBoxyurtici.FormattingEnabled = true;
            this.comboBoxyurtici.Location = new System.Drawing.Point(678, 15);
            this.comboBoxyurtici.Name = "comboBoxyurtici";
            this.comboBoxyurtici.Size = new System.Drawing.Size(364, 24);
            this.comboBoxyurtici.TabIndex = 23;
            // 
            // comboBoxyurtdisi
            // 
            this.comboBoxyurtdisi.FormattingEnabled = true;
            this.comboBoxyurtdisi.Location = new System.Drawing.Point(678, 48);
            this.comboBoxyurtdisi.Name = "comboBoxyurtdisi";
            this.comboBoxyurtdisi.Size = new System.Drawing.Size(364, 24);
            this.comboBoxyurtdisi.TabIndex = 24;
            // 
            // textBoxtelNo
            // 
            this.textBoxtelNo.Location = new System.Drawing.Point(678, 131);
            this.textBoxtelNo.Name = "textBoxtelNo";
            this.textBoxtelNo.Size = new System.Drawing.Size(364, 22);
            this.textBoxtelNo.TabIndex = 26;
            // 
            // comboBoxekip
            // 
            this.comboBoxekip.FormattingEnabled = true;
            this.comboBoxekip.Location = new System.Drawing.Point(676, 164);
            this.comboBoxekip.Name = "comboBoxekip";
            this.comboBoxekip.Size = new System.Drawing.Size(366, 24);
            this.comboBoxekip.TabIndex = 27;
            // 
            // comboBoxproje
            // 
            this.comboBoxproje.FormattingEnabled = true;
            this.comboBoxproje.Location = new System.Drawing.Point(676, 201);
            this.comboBoxproje.Name = "comboBoxproje";
            this.comboBoxproje.Size = new System.Drawing.Size(366, 24);
            this.comboBoxproje.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 339);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxmaas
            // 
            this.textBoxmaas.Location = new System.Drawing.Point(678, 88);
            this.textBoxmaas.Name = "textBoxmaas";
            this.textBoxmaas.Size = new System.Drawing.Size(364, 22);
            this.textBoxmaas.TabIndex = 30;
            // 
            // yurtdisibutton
            // 
            this.yurtdisibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yurtdisibutton.Location = new System.Drawing.Point(583, 245);
            this.yurtdisibutton.Name = "yurtdisibutton";
            this.yurtdisibutton.Size = new System.Drawing.Size(191, 74);
            this.yurtdisibutton.TabIndex = 31;
            this.yurtdisibutton.Text = "YURTDIŞI DENEYİMİ OLAN PERSONELLERİ LİSTELE";
            this.yurtdisibutton.UseVisualStyleBackColor = true;
            this.yurtdisibutton.Click += new System.EventHandler(this.yurtdisibutton_Click);
            // 
            // yurticibutton
            // 
            this.yurticibutton.Location = new System.Drawing.Point(794, 245);
            this.yurticibutton.Name = "yurticibutton";
            this.yurticibutton.Size = new System.Drawing.Size(180, 74);
            this.yurticibutton.TabIndex = 32;
            this.yurticibutton.Text = "YURTİÇİ DENEYİMİ OLAN PERSONELLERİ LİSTELE";
            this.yurticibutton.UseVisualStyleBackColor = true;
            this.yurticibutton.Click += new System.EventHandler(this.yurticibutton_Click);
            // 
            // kayitliPersonelbutton
            // 
            this.kayitliPersonelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitliPersonelbutton.Location = new System.Drawing.Point(994, 245);
            this.kayitliPersonelbutton.Name = "kayitliPersonelbutton";
            this.kayitliPersonelbutton.Size = new System.Drawing.Size(137, 74);
            this.kayitliPersonelbutton.TabIndex = 33;
            this.kayitliPersonelbutton.Text = "KAYITLI PERSONEL SAYISI";
            this.kayitliPersonelbutton.UseVisualStyleBackColor = true;
            this.kayitliPersonelbutton.Click += new System.EventHandler(this.kayitliPersonelbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 666);
            this.Controls.Add(this.kayitliPersonelbutton);
            this.Controls.Add(this.yurticibutton);
            this.Controls.Add(this.yurtdisibutton);
            this.Controls.Add(this.textBoxmaas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxproje);
            this.Controls.Add(this.comboBoxekip);
            this.Controls.Add(this.textBoxtelNo);
            this.Controls.Add(this.comboBoxyurtdisi);
            this.Controls.Add(this.comboBoxyurtici);
            this.Controls.Add(this.comboBoxyuzyuze);
            this.Controls.Add(this.comboBoxuzaktan);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.comboBoxil);
            this.Controls.Add(this.textBoxadSoyad);
            this.Controls.Add(this.textBoxpersonelId);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.personelId);
            this.Controls.Add(this.proje);
            this.Controls.Add(this.ekip);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.yurtdisiDeneyim);
            this.Controls.Add(this.yurticiDeneyim);
            this.Controls.Add(this.yuzyuze);
            this.Controls.Add(this.uzaktan);
            this.Controls.Add(this.ilce);
            this.Controls.Add(this.il);
            this.Controls.Add(this.adSoyad);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Label ilce;
        private System.Windows.Forms.Label uzaktan;
        private System.Windows.Forms.Label yuzyuze;
        private System.Windows.Forms.Label yurticiDeneyim;
        private System.Windows.Forms.Label yurtdisiDeneyim;
        private System.Windows.Forms.Label maas;
        private System.Windows.Forms.Label telNo;
        private System.Windows.Forms.Label ekip;
        private System.Windows.Forms.Label proje;
        private System.Windows.Forms.Label personelId;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.TextBox textBoxpersonelId;
        private System.Windows.Forms.TextBox textBoxadSoyad;
        private System.Windows.Forms.ComboBox comboBoxil;
        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.ComboBox comboBoxuzaktan;
        private System.Windows.Forms.ComboBox comboBoxyuzyuze;
        private System.Windows.Forms.ComboBox comboBoxyurtici;
        private System.Windows.Forms.ComboBox comboBoxyurtdisi;
        private System.Windows.Forms.TextBox textBoxtelNo;
        private System.Windows.Forms.ComboBox comboBoxekip;
        private System.Windows.Forms.ComboBox comboBoxproje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxmaas;
        private System.Windows.Forms.Button yurtdisibutton;
        private System.Windows.Forms.Button yurticibutton;
        private System.Windows.Forms.Button kayitliPersonelbutton;
    }
}

