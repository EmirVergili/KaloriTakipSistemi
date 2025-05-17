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
            lnkKayitOl = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(67, 193);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            label1.Click += label1_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Century Gothic", 12F);
            txtKullaniciAdi.Location = new Point(208, 187);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(170, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(199, 234, 203);
            btnGirisYap.FlatStyle = FlatStyle.Popup;
            btnGirisYap.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(168, 352);
            btnGirisYap.Margin = new Padding(4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(158, 49);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // chbGoster
            // 
            chbGoster.AutoSize = true;
            chbGoster.Font = new Font("Century Gothic", 12F);
            chbGoster.Location = new Point(208, 267);
            chbGoster.Margin = new Padding(4);
            chbGoster.Name = "chbGoster";
            chbGoster.Size = new Size(154, 27);
            chbGoster.TabIndex = 3;
            chbGoster.Text = "Şifreyi Göster";
            chbGoster.UseVisualStyleBackColor = true;
            chbGoster.CheckedChanged += chbGoster_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(67, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Century Gothic", 12F);
            txtSifre.Location = new Point(208, 233);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(170, 32);
            txtSifre.TabIndex = 1;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.Font = new Font("Century Gothic", 12F);
            lnkKayitOl.LinkColor = Color.Green;
            lnkKayitOl.Location = new Point(67, 310);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(79, 23);
            lnkKayitOl.TabIndex = 4;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Kaydol";
            lnkKayitOl.LinkClicked += lnkKayitOl_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(146, 112);
            label3.Name = "label3";
            label3.Size = new Size(203, 37);
            label3.TabIndex = 22;
            label3.Text = "Kullanıcı Giriş";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.top_view_healthy_ingredients_bowls_white_background_with_blank_space_text;
            pictureBox1.Location = new Point(-358, -248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1127, 900);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FRMKullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 475);
            Controls.Add(lnkKayitOl);
            Controls.Add(chbGoster);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FRMKullaniciGirisEkrani";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private LinkLabel lnkKayitOl;
        private Label label3;
        private PictureBox pictureBox1;
    }
}