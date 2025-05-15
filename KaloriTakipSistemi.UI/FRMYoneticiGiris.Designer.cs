namespace KaloriTakipSistemi.UI
{
    partial class FRMYoneticiGiris
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            chbGoster = new CheckBox();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(15, 26);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 21);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(15, 100);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 21);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(149, 26);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(127, 29);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(149, 100);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(127, 29);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(149, 214);
            btnGiris.Margin = new Padding(4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(96, 32);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // chbGoster
            // 
            chbGoster.AutoSize = true;
            chbGoster.Location = new Point(315, 104);
            chbGoster.Margin = new Padding(4);
            chbGoster.Name = "chbGoster";
            chbGoster.Size = new Size(129, 25);
            chbGoster.TabIndex = 6;
            chbGoster.Text = "Şifremi Göster";
            chbGoster.UseVisualStyleBackColor = true;
            chbGoster.CheckedChanged += chbGoster_CheckedChanged;
            // 
            // FRMYoneticiGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 373);
            Controls.Add(chbGoster);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMYoneticiGiris";
            Text = "Yönetici Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private CheckBox chbGoster;
    }
}