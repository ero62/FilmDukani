namespace ntpOdev2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFilmAd = new TextBox();
            txtFilmTur = new TextBox();
            txtFilmUcret = new TextBox();
            btnFilmEkle = new Button();
            dataGridView1 = new DataGridView();
            txtKisiAd = new TextBox();
            txtKisiSoyad = new TextBox();
            btnKisiEkle = new Button();
            dataGridView2 = new DataGridView();
            txtKisiId = new TextBox();
            txtFilmId = new TextBox();
            txtKiralamaGun = new TextBox();
            btnKiralamaEkle = new Button();
            dataGridView3 = new DataGridView();
            btnVerileriKaydet = new Button();
            btnVerileriOku = new Button();
            lblFilmAd = new Label();
            lblFilmTur = new Label();
            lblFilmUcret = new Label();
            lblKisiAd = new Label();
            lblKisiSoyad = new Label();
            lblKisiId = new Label();
            lblFilmId = new Label();
            lblKiralamaGun = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // txtFilmAd
            // 
            txtFilmAd.Location = new Point(98, 18);
            txtFilmAd.Margin = new Padding(4, 3, 4, 3);
            txtFilmAd.Name = "txtFilmAd";
            txtFilmAd.Size = new Size(116, 23);
            txtFilmAd.TabIndex = 0;
            // 
            // txtFilmTur
            // 
            txtFilmTur.Location = new Point(98, 47);
            txtFilmTur.Margin = new Padding(4, 3, 4, 3);
            txtFilmTur.Name = "txtFilmTur";
            txtFilmTur.Size = new Size(116, 23);
            txtFilmTur.TabIndex = 1;
            // 
            // txtFilmUcret
            // 
            txtFilmUcret.Location = new Point(98, 76);
            txtFilmUcret.Margin = new Padding(4, 3, 4, 3);
            txtFilmUcret.Name = "txtFilmUcret";
            txtFilmUcret.Size = new Size(116, 23);
            txtFilmUcret.TabIndex = 2;
            // 
            // btnFilmEkle
            // 
            btnFilmEkle.Location = new Point(14, 119);
            btnFilmEkle.Margin = new Padding(4, 3, 4, 3);
            btnFilmEkle.Name = "btnFilmEkle";
            btnFilmEkle.Size = new Size(117, 27);
            btnFilmEkle.TabIndex = 3;
            btnFilmEkle.Text = "Film Ekle";
            btnFilmEkle.UseVisualStyleBackColor = true;
            btnFilmEkle.Click += btnFilmEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 152);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(467, 173);
            dataGridView1.TabIndex = 4;
            // 
            // txtKisiAd
            // 
            txtKisiAd.Location = new Point(136, 339);
            txtKisiAd.Margin = new Padding(4, 3, 4, 3);
            txtKisiAd.Name = "txtKisiAd";
            txtKisiAd.Size = new Size(116, 23);
            txtKisiAd.TabIndex = 5;
            // 
            // txtKisiSoyad
            // 
            txtKisiSoyad.Location = new Point(136, 368);
            txtKisiSoyad.Margin = new Padding(4, 3, 4, 3);
            txtKisiSoyad.Name = "txtKisiSoyad";
            txtKisiSoyad.Size = new Size(116, 23);
            txtKisiSoyad.TabIndex = 6;
            // 
            // btnKisiEkle
            // 
            btnKisiEkle.Location = new Point(14, 392);
            btnKisiEkle.Margin = new Padding(4, 3, 4, 3);
            btnKisiEkle.Name = "btnKisiEkle";
            btnKisiEkle.Size = new Size(117, 27);
            btnKisiEkle.TabIndex = 7;
            btnKisiEkle.Text = "Kişi Ekle";
            btnKisiEkle.UseVisualStyleBackColor = true;
            btnKisiEkle.Click += btnKisiEkle_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 426);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(467, 173);
            dataGridView2.TabIndex = 8;
            // 
            // txtKisiId
            // 
            txtKisiId.Location = new Point(670, 29);
            txtKisiId.Margin = new Padding(4, 3, 4, 3);
            txtKisiId.Name = "txtKisiId";
            txtKisiId.Size = new Size(116, 23);
            txtKisiId.TabIndex = 9;
            // 
            // txtFilmId
            // 
            txtFilmId.Location = new Point(670, 59);
            txtFilmId.Margin = new Padding(4, 3, 4, 3);
            txtFilmId.Name = "txtFilmId";
            txtFilmId.Size = new Size(116, 23);
            txtFilmId.TabIndex = 10;
            // 
            // txtKiralamaGun
            // 
            txtKiralamaGun.Location = new Point(670, 89);
            txtKiralamaGun.Margin = new Padding(4, 3, 4, 3);
            txtKiralamaGun.Name = "txtKiralamaGun";
            txtKiralamaGun.Size = new Size(116, 23);
            txtKiralamaGun.TabIndex = 11;
            // 
            // btnKiralamaEkle
            // 
            btnKiralamaEkle.Location = new Point(670, 119);
            btnKiralamaEkle.Margin = new Padding(4, 3, 4, 3);
            btnKiralamaEkle.Name = "btnKiralamaEkle";
            btnKiralamaEkle.Size = new Size(117, 27);
            btnKiralamaEkle.TabIndex = 12;
            btnKiralamaEkle.Text = "Kiralama Ekle";
            btnKiralamaEkle.UseVisualStyleBackColor = true;
            btnKiralamaEkle.Click += btnKiralamaEkle_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(574, 152);
            dataGridView3.Margin = new Padding(4, 3, 4, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(467, 173);
            dataGridView3.TabIndex = 13;
            // 
            // btnVerileriKaydet
            // 
            btnVerileriKaydet.Location = new Point(805, 477);
            btnVerileriKaydet.Margin = new Padding(4, 3, 4, 3);
            btnVerileriKaydet.Name = "btnVerileriKaydet";
            btnVerileriKaydet.Size = new Size(117, 79);
            btnVerileriKaydet.TabIndex = 14;
            btnVerileriKaydet.Text = "Verileri Kaydet";
            btnVerileriKaydet.UseVisualStyleBackColor = true;
            btnVerileriKaydet.Click += btnVerileriKaydet_Click;
            // 
            // btnVerileriOku
            // 
            btnVerileriOku.Location = new Point(681, 477);
            btnVerileriOku.Margin = new Padding(4, 3, 4, 3);
            btnVerileriOku.Name = "btnVerileriOku";
            btnVerileriOku.Size = new Size(117, 79);
            btnVerileriOku.TabIndex = 15;
            btnVerileriOku.Text = "Verileri Oku";
            btnVerileriOku.UseVisualStyleBackColor = true;
            btnVerileriOku.Click += btnVerileriOku_Click;
            // 
            // lblFilmAd
            // 
            lblFilmAd.AutoSize = true;
            lblFilmAd.Location = new Point(17, 21);
            lblFilmAd.Margin = new Padding(4, 0, 4, 0);
            lblFilmAd.Name = "lblFilmAd";
            lblFilmAd.Size = new Size(54, 15);
            lblFilmAd.TabIndex = 16;
            lblFilmAd.Text = "Film Adı:";
            // 
            // lblFilmTur
            // 
            lblFilmTur.AutoSize = true;
            lblFilmTur.Location = new Point(17, 51);
            lblFilmTur.Margin = new Padding(4, 0, 4, 0);
            lblFilmTur.Name = "lblFilmTur";
            lblFilmTur.Size = new Size(60, 15);
            lblFilmTur.TabIndex = 17;
            lblFilmTur.Text = "Film Türü:";
            // 
            // lblFilmUcret
            // 
            lblFilmUcret.AutoSize = true;
            lblFilmUcret.Location = new Point(17, 81);
            lblFilmUcret.Margin = new Padding(4, 0, 4, 0);
            lblFilmUcret.Name = "lblFilmUcret";
            lblFilmUcret.Size = new Size(67, 15);
            lblFilmUcret.TabIndex = 18;
            lblFilmUcret.Text = "Film Ücreti:";
            // 
            // lblKisiAd
            // 
            lblKisiAd.AutoSize = true;
            lblKisiAd.Location = new Point(17, 339);
            lblKisiAd.Margin = new Padding(4, 0, 4, 0);
            lblKisiAd.Name = "lblKisiAd";
            lblKisiAd.Size = new Size(49, 15);
            lblKisiAd.TabIndex = 19;
            lblKisiAd.Text = "Kişi Adı:";
            // 
            // lblKisiSoyad
            // 
            lblKisiSoyad.AutoSize = true;
            lblKisiSoyad.Location = new Point(17, 368);
            lblKisiSoyad.Margin = new Padding(4, 0, 4, 0);
            lblKisiSoyad.Name = "lblKisiSoyad";
            lblKisiSoyad.Size = new Size(66, 15);
            lblKisiSoyad.TabIndex = 20;
            lblKisiSoyad.Text = "Kişi Soyadı:";
            // 
            // lblKisiId
            // 
            lblKisiId.AutoSize = true;
            lblKisiId.Location = new Point(620, 32);
            lblKisiId.Margin = new Padding(4, 0, 4, 0);
            lblKisiId.Name = "lblKisiId";
            lblKisiId.Size = new Size(42, 15);
            lblKisiId.TabIndex = 21;
            lblKisiId.Text = "Kişi ID:";
            // 
            // lblFilmId
            // 
            lblFilmId.AutoSize = true;
            lblFilmId.Location = new Point(615, 62);
            lblFilmId.Margin = new Padding(4, 0, 4, 0);
            lblFilmId.Name = "lblFilmId";
            lblFilmId.Size = new Size(47, 15);
            lblFilmId.TabIndex = 22;
            lblFilmId.Text = "Film ID:";
            // 
            // lblKiralamaGun
            // 
            lblKiralamaGun.AutoSize = true;
            lblKiralamaGun.Location = new Point(581, 97);
            lblKiralamaGun.Margin = new Padding(4, 0, 4, 0);
            lblKiralamaGun.Name = "lblKiralamaGun";
            lblKiralamaGun.Size = new Size(81, 15);
            lblKiralamaGun.TabIndex = 23;
            lblKiralamaGun.Text = "Kiralama Gün:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 678);
            Controls.Add(lblKiralamaGun);
            Controls.Add(lblFilmId);
            Controls.Add(lblKisiId);
            Controls.Add(lblKisiSoyad);
            Controls.Add(lblKisiAd);
            Controls.Add(lblFilmUcret);
            Controls.Add(lblFilmTur);
            Controls.Add(lblFilmAd);
            Controls.Add(btnVerileriOku);
            Controls.Add(btnVerileriKaydet);
            Controls.Add(dataGridView3);
            Controls.Add(btnKiralamaEkle);
            Controls.Add(txtKiralamaGun);
            Controls.Add(txtFilmId);
            Controls.Add(txtKisiId);
            Controls.Add(dataGridView2);
            Controls.Add(btnKisiEkle);
            Controls.Add(txtKisiSoyad);
            Controls.Add(txtKisiAd);
            Controls.Add(dataGridView1);
            Controls.Add(btnFilmEkle);
            Controls.Add(txtFilmUcret);
            Controls.Add(txtFilmTur);
            Controls.Add(txtFilmAd);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Film Kiralama";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.TextBox txtFilmTur;
        private System.Windows.Forms.TextBox txtFilmUcret;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtKisiId;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.TextBox txtKiralamaGun;
        private System.Windows.Forms.Button btnKiralamaEkle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnVerileriKaydet;
        private System.Windows.Forms.Button btnVerileriOku;
        private System.Windows.Forms.Label lblFilmAd;
        private System.Windows.Forms.Label lblFilmTur;
        private System.Windows.Forms.Label lblFilmUcret;
        private System.Windows.Forms.Label lblKisiAd;
        private System.Windows.Forms.Label lblKisiSoyad;
        private System.Windows.Forms.Label lblKisiId;
        private System.Windows.Forms.Label lblFilmId;
        private System.Windows.Forms.Label lblKiralamaGun;
    }
}
