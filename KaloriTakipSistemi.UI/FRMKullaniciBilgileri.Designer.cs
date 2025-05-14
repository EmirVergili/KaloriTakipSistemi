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
            lbl.Location = new Point(26, 43);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(120, 28);
            lbl.TabIndex = 0;
            lbl.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(76, 170);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(70, 28);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "SoyAd";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(107, 251);
            lblYas.Margin = new Padding(4, 0, 4, 0);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(39, 28);
            lblYas.TabIndex = 3;
            lblYas.Text = "Yaş";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(95, 320);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(51, 28);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(172, 179);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.ReadOnly = true;
            txtSoyad.Size = new Size(127, 34);
            txtSoyad.TabIndex = 6;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(172, 245);
            txtYas.Margin = new Padding(4);
            txtYas.Name = "txtYas";
            txtYas.ReadOnly = true;
            txtYas.Size = new Size(127, 34);
            txtYas.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(172, 314);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.ReadOnly = true;
            txtSifre.Size = new Size(127, 34);
            txtSifre.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(172, 106);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(127, 34);
            txtAd.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(300, 384);
            btnGuncelle.Margin = new Padding(4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(138, 77);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(172, 43);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(113, 28);
            lblKullaniciAdi.TabIndex = 13;
            lblKullaniciAdi.Text = "kullaniciAdi";
            // 
            // chbBilgilerimiGuncelle
            // 
            chbBilgilerimiGuncelle.AutoSize = true;
            chbBilgilerimiGuncelle.Location = new Point(431, 43);
            chbBilgilerimiGuncelle.Name = "chbBilgilerimiGuncelle";
            chbBilgilerimiGuncelle.Size = new Size(196, 32);
            chbBilgilerimiGuncelle.TabIndex = 14;
            chbBilgilerimiGuncelle.Text = "Bilgilerimi Düzenle";
            chbBilgilerimiGuncelle.UseVisualStyleBackColor = true;
            chbBilgilerimiGuncelle.CheckedChanged += chbBilgilerimiGuncelle_CheckedChanged;
            // 
            // FRMKullaniciBilgileri
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
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