namespace KaloriTakipSistemi.UI
{
    partial class FRMKullaniciBilgileri
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
            lbl = new Label();
            label2 = new Label();
            lblSoyad = new Label();
            lblYas = new Label();
            lblSifre = new Label();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            txtSifre = new TextBox();
            txtAd = new TextBox();
            btnGuncelle = new Button();
            lblKullaniciAdi = new Label();
            chbBilgilerimiGuncelle = new CheckBox();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(28, 35);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(133, 23);
            lbl.TabIndex = 0;
            lbl.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(83, 140);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(73, 23);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "SoyAd";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(117, 206);
            lblYas.Margin = new Padding(4, 0, 4, 0);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(45, 23);
            lblYas.TabIndex = 3;
            lblYas.Text = "Yaş";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(104, 263);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(188, 147);
            txtSoyad.Margin = new Padding(4, 3, 4, 3);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.ReadOnly = true;
            txtSoyad.Size = new Size(138, 32);
            txtSoyad.TabIndex = 6;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(188, 201);
            txtYas.Margin = new Padding(4, 3, 4, 3);
            txtYas.Name = "txtYas";
            txtYas.ReadOnly = true;
            txtYas.Size = new Size(138, 32);
            txtYas.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(188, 258);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.ReadOnly = true;
            txtSifre.Size = new Size(138, 32);
            txtSifre.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(188, 87);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(138, 32);
            txtAd.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(327, 315);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(151, 63);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(188, 35);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(119, 23);
            lblKullaniciAdi.TabIndex = 13;
            lblKullaniciAdi.Text = "kullaniciAdi";
            // 
            // chbBilgilerimiGuncelle
            // 
            chbBilgilerimiGuncelle.AutoSize = true;
            chbBilgilerimiGuncelle.Location = new Point(470, 35);
            chbBilgilerimiGuncelle.Margin = new Padding(3, 2, 3, 2);
            chbBilgilerimiGuncelle.Name = "chbBilgilerimiGuncelle";
            chbBilgilerimiGuncelle.Size = new Size(201, 27);
            chbBilgilerimiGuncelle.TabIndex = 14;
            chbBilgilerimiGuncelle.Text = "Bilgilerimi Düzenle";
            chbBilgilerimiGuncelle.UseVisualStyleBackColor = true;
            chbBilgilerimiGuncelle.CheckedChanged += chbBilgilerimiGuncelle_CheckedChanged;
            // 
            // FRMKullaniciBilgileri
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(chbBilgilerimiGuncelle);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(txtAd);
            Controls.Add(txtSifre);
            Controls.Add(txtYas);
            Controls.Add(txtSoyad);
            Controls.Add(lblSifre);
            Controls.Add(lblYas);
            Controls.Add(lblSoyad);
            Controls.Add(label2);
            Controls.Add(lbl);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMKullaniciBilgileri";
            Text = "FRMKullaniciBilgileri";
            Load += FRMKullaniciBilgileri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label2;
        private Label lblSoyad;
        private Label lblYas;
        private Label lblSifre;
        private Label label6;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtSifre;
        private TextBox textBox4;
        private TextBox txtAd;
        private Button btnGuncelle;
        private Label lblKullaniciAdi;
        private CheckBox chbBilgilerimiGuncelle;
    }
}