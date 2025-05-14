namespace KaloriTakipSistemi.UI
{
    partial class FRMKullaniciGirisEkrani
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
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            btnGirisYap = new Button();
            chbGoster = new CheckBox();
            label2 = new Label();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            label1.Click += label1_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(197, 76);
            txtKullaniciAdi.Margin = new Padding(4, 4, 4, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(170, 34);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TextChanged += this.txtKullaniciAdi_TextChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(144, 282);
            btnGirisYap.Margin = new Padding(4, 4, 4, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(158, 49);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += this.btnGirisYap_Click;
            // 
            // chbGoster
            // 
            chbGoster.AutoSize = true;
            chbGoster.Location = new Point(69, 213);
            chbGoster.Margin = new Padding(4, 4, 4, 4);
            chbGoster.Name = "chbGoster";
            chbGoster.Size = new Size(158, 32);
            chbGoster.TabIndex = 3;
            chbGoster.Text = "Şifremi Göster";
            chbGoster.UseVisualStyleBackColor = true;
            chbGoster.CheckedChanged += this.chbGoster_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            label2.Click += this.label2_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(197, 157);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(170, 34);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += this.txtSifre_TextChanged;
            // 
            // FRMKullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 412);
            Controls.Add(chbGoster);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FRMKullaniciGirisEkrani";
            Text = "Kullanıcı Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Button btnGirisYap;
        private CheckBox chbGoster;
        private Label label2;
        private TextBox txtSifre;
    }
}