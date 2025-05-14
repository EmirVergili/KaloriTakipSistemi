namespace KaloriTakipSistemi.UI
{
    partial class FRMKayitOl
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
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblSifreTekrar = new Label();
            lblAd = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnKayitOl = new Button();
            lblSoyad = new Label();
            lblYas = new Label();
            txtYas = new TextBox();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(22, 65);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 21);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(22, 117);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 21);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Location = new Point(21, 164);
            lblSifreTekrar.Margin = new Padding(4, 0, 4, 0);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(88, 21);
            lblSifreTekrar.TabIndex = 2;
            lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(21, 232);
            lblAd.Margin = new Padding(4, 0, 4, 0);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 21);
            lblAd.TabIndex = 3;
            lblAd.Text = "Ad";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(153, 62);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(127, 29);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(139, 109);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(127, 29);
            txtSifre.TabIndex = 6;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(127, 164);
            txtSifreTekrar.Margin = new Padding(4);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(127, 29);
            txtSifreTekrar.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(127, 232);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(127, 29);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(127, 300);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(127, 29);
            txtSoyad.TabIndex = 9;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(139, 486);
            btnKayitOl.Margin = new Padding(4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(115, 49);
            btnKayitOl.TabIndex = 10;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(21, 303);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 21);
            lblSoyad.TabIndex = 11;
            lblSoyad.Text = "Soyad";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(22, 380);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(33, 21);
            lblYas.TabIndex = 13;
            lblYas.Text = "Yaş";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(127, 380);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(100, 29);
            txtYas.TabIndex = 14;
            // 
            // FRMKayitOl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(txtYas);
            Controls.Add(lblYas);
            Controls.Add(lblSoyad);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblAd);
            Controls.Add(lblSifreTekrar);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMKayitOl";
            Text = "FRMKayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Label lblSifreTekrar;
        private Label lblAd;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnKayitOl;
        private Label lblSoyad;
        private Label lblYas;
        private TextBox txtYas;
    }
}