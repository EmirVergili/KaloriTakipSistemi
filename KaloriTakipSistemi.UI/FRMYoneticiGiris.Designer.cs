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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Century Gothic", 12F);
            lblKullaniciAdi.Location = new Point(67, 193);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(133, 23);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Century Gothic", 12F);
            lblSifre.Location = new Point(67, 236);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Century Gothic", 12F);
            txtKullaniciAdi.Location = new Point(208, 187);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(170, 32);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Century Gothic", 12F);
            txtSifre.Location = new Point(208, 233);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(170, 32);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(199, 234, 203);
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(168, 352);
            btnGiris.Margin = new Padding(4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(158, 49);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // chbGoster
            // 
            chbGoster.AutoSize = true;
            chbGoster.Font = new Font("Century Gothic", 12F);
            chbGoster.Location = new Point(206, 271);
            chbGoster.Margin = new Padding(4);
            chbGoster.Name = "chbGoster";
            chbGoster.Size = new Size(154, 27);
            chbGoster.TabIndex = 6;
            chbGoster.Text = "Şifreyi Göster";
            chbGoster.UseVisualStyleBackColor = true;
            chbGoster.CheckedChanged += chbGoster_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.top_view_healthy_ingredients_bowls_white_background_with_blank_space_text;
            pictureBox1.Location = new Point(-358, -248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1127, 900);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(146, 112);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 18;
            label2.Text = "Yönetici Giriş";
            // 
            // FRMYoneticiGiris
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 475);
            Controls.Add(label2);
            Controls.Add(chbGoster);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMYoneticiGiris";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label2;
    }
}