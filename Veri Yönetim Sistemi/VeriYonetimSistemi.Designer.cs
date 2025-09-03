namespace Veri_Yönetim_Sistemi
{
    partial class VeriYonetimSistemi
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
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            txtKAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKSifre = new TextBox();
            label6 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            label5 = new Label();
            cmbKullaniciTur = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(228, 258);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(412, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(150, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 53);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "ID : ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(150, 82);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Ad : ";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(150, 115);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtKAd
            // 
            txtKAd.Location = new Point(150, 148);
            txtKAd.Name = "txtKAd";
            txtKAd.Size = new Size(125, 27);
            txtKAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 118);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Soyad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 155);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Kullanıcı Adı : ";
            // 
            // txtKSifre
            // 
            txtKSifre.Location = new Point(150, 181);
            txtKSifre.Name = "txtKSifre";
            txtKSifre.Size = new Size(125, 27);
            txtKSifre.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 188);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 3;
            label6.Text = "Kullanıcı Şifre : ";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(364, 258);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(499, 258);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 217);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 3;
            label5.Text = "Kullanıcı Türü : ";
            // 
            // cmbKullaniciTur
            // 
            cmbKullaniciTur.FormattingEnabled = true;
            cmbKullaniciTur.Location = new Point(150, 214);
            cmbKullaniciTur.Name = "cmbKullaniciTur";
            cmbKullaniciTur.Size = new Size(125, 28);
            cmbKullaniciTur.TabIndex = 4;
            // 
            // VeriYonetimSistemi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 312);
            Controls.Add(cmbKullaniciTur);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtKAd);
            Controls.Add(txtKSifre);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "VeriYonetimSistemi";
            Text = "VeriYonetimSistemi";
            Load += VeriYonetimSistemi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private DataGridView dataGridView1;
        private TextBox txtId;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtSoyad;
        private TextBox txtKAd;
        private Label label3;
        private Label label4;
        private TextBox txtKSifre;
        private Label label6;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label5;
        private ComboBox cmbKullaniciTur;
    }
}